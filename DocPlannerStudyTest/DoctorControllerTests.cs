using AutoFixture;
using AutoMapper;
using DocPlannerStudyCase.Controllers;
using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Services;
using DocPlannerStudyCase.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace DocPlannerStudyTest
{
    public class DoctorControllerTests
    {
        private Mock<DoctorService> _serviceDoctorMock;
        private Fixture _fixter;

        public DoctorControllerTests()
        {
            _serviceDoctorMock = new Mock<DoctorService>();
            _fixter = new Fixture();
        }


        [Fact]
        public async Task Fetch_Doctor_ReturnOk()
        {
            var doctorList = _fixter.CreateMany<DoctorVM>(10).ToList();

            _serviceDoctorMock.Setup(repo => repo.GetDoctors()).Returns(doctorList);
            var controller = new DoctorController(_serviceDoctorMock.Object);
            var result =await controller.FetchDoctors();
            var obj = result as ObjectResult;

            Assert.Equal(200, obj.StatusCode);
        }
    }
}