using AutoMapper;
using DocPlannerStudyCase.GenericRepository.ConcRep;
using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Helper;
using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Models.Enums;
using DocPlannerStudyCase.Services.IServices;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace DocPlannerStudyCase.Services
{
    public class BookVisitService : IBookVisitService
    {
        private readonly IRepository<BookVisit> _bookVisitRepository;
        private readonly IRepository<Schedule> _scheduleRepository;
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IMapper _mapper;
        public BookVisitService(IMapper mapper, IRepository<BookVisit> bookVisitRepository, IRepository<Schedule> scheduleRepository, IRepository<Doctor> doctorRepository)
        {
            _mapper = mapper;
            _bookVisitRepository = bookVisitRepository;
            _scheduleRepository = scheduleRepository;
            _doctorRepository = doctorRepository;
        }

        /* 
         * başarılı durumlarda 0'dan büyük bir sayı döner
         * -4, schedule bilgileri yanlışsa
         * -3, doktor bilgileri yanlışsa 
         * -2, validasyon hatalarında
         * -1, diğer exceptional durumlarda
         */
        public int AddBookVisit(BookVisitVM bookVisitVM)
        {
            int bookingId = -1;
            try
            {
                // validasyon yapılacak
                if (bookVisitVM.DoctorId <= 0)
                {
                    return -2;
                }

                if (string.IsNullOrEmpty(bookVisitVM.Date) || string.IsNullOrEmpty(bookVisitVM.StartTime) || string.IsNullOrEmpty(bookVisitVM.EndTime))
                {
                    return -2;
                }

                Doctor doctor = _doctorRepository.Find(bookVisitVM.DoctorId);
                if (bookVisitVM.HospitalId != doctor.HospitalId || bookVisitVM.BranchId != (int)doctor.BranchId)
                {
                    return -3;
                }

                bool b1 = DateHelper.isValid(bookVisitVM.Date, "dd/MM/yyyy");
                bool b2 = DateHelper.isValid(bookVisitVM.StartTime, "HH:mm");
                bool b3 = DateHelper.isValid(bookVisitVM.EndTime, "HH:mm");


                if (! DateHelper.isValid(bookVisitVM.Date, "dd/MM/yyyy") ||
                    ! DateHelper.isValid(bookVisitVM.StartTime, "HH:mm") ||
                    ! DateHelper.isValid(bookVisitVM.EndTime, "HH:mm"))
                {
                    return -2;
                }

                // Parametre olarak verilen tarihlerin kontrolleri
                var visitStartDate = DateHelper.String2DateTime(bookVisitVM.Date + " " + bookVisitVM.StartTime);
                var visitEndDate   = DateHelper.String2DateTime(bookVisitVM.Date + " " + bookVisitVM.EndTime);
                if (visitStartDate == null || visitEndDate == null)
                {
                    return -2;
                }

                Schedule? schedule = _scheduleRepository.Where(s => s.VisitId == bookVisitVM.VisitId && 
                                                                    s.AppointmentStatus != AppointmentStatus.Appointment &&
                                                                    s.StartTime == visitStartDate &&
                                                                    s.EndTime  == visitEndDate).FirstOrDefault();

                if (schedule == null)
                {
                    return -4;
                }

                BookVisit bookVisit = _mapper.Map<BookVisit>(bookVisitVM);
                _bookVisitRepository.Add(bookVisit);
                bookingId = bookVisit.Id;


                schedule.AppointmentStatus = Models.Enums.AppointmentStatus.Appointment;
                _scheduleRepository.Update(schedule);
            }
            catch (Exception e)
            {
                bookingId = -1;
            }

            return bookingId;
        }

        public bool CancelBookVisit(int? bookingId)
        {
            if (bookingId <= 0)
            {
                return false;
            }

            var success = false;
            try
            {
                BookVisit? bookVisit = _bookVisitRepository.Where(x => x.Id == bookingId && x.Status != DataStatus.Deleted).FirstOrDefault();
                if (bookVisit is null)
                {
                    return false;
                }
                
                _bookVisitRepository.Delete(bookVisit);

                Schedule? schedule = _scheduleRepository.Where(s => s.VisitId == bookVisit.VisitId && s.AppointmentStatus == AppointmentStatus.Appointment).FirstOrDefault();
                // ilgili doktorun schedule'ı kaldırılmışsa false dön
                if (schedule is null)
                {
                    return false;
                }

                schedule.AppointmentStatus = AppointmentStatus.Available;
                _scheduleRepository.Update(schedule);

                success = true;
            }
            catch (Exception e)
            {
                success = false;
            }

            return success;
        }
    }
}
