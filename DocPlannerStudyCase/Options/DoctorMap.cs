using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocPlannerStudyCase.Options
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {   

            //builder.Property(x => x.DoctorId).IsRequired();
            builder.HasData(new Doctor[]
            {
                new()
                {
                    Id = 1,
                    CreatedAt    = DateTime.Parse("2022-04-29T02:25:52.521Z"),
                    Name         = "Mr. Ahmet Öz",
                    Gender       = Gender.male,
                    HospitalName = "Medicana Avcilar",
                    HospitalId   = 150,
                    SpecialtyId  = 81036,
                    BranchId     = 29532.99,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },
                new()
                {
                    Id = 2,
                    CreatedAt    = DateTime.Parse("2022-04-29T02:25:52.521Z"),
                    Name         = "Ahmet Pınar",
                    Gender       = Gender.male,
                    HospitalName = "Medicana Avcilar",
                    HospitalId   = 150,
                    SpecialtyId  = 81036,
                    BranchId     = 29532.99,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },
                new()
                {
                    Id = 3,
                    CreatedAt    = DateTime.Parse("2021-12-29T20:34:25.337Z"),
                    Name         = "Yasemin Öztürk",
                    Gender       = Gender.female,
                    HospitalName = "MedicalPark İzmir",
                    HospitalId   = 160,
                    SpecialtyId  = 81036,
                    BranchId     = 45145.08,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 4,
                    CreatedAt    = DateTime.Parse("2022-04-30T04:05:06.158Z"),
                    Name         = "Kübra Işık",
                    Gender       = Gender.female,
                    HospitalName = "MedicalPark Kadiköy",
                    HospitalId   = 160,
                    SpecialtyId  = 18741,
                    BranchId     = 49875.59,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 5,
                    CreatedAt    = DateTime.Parse("2021-05-27T21:24:21.743Z"),
                    Name         = "Aynur Aslan",
                    Gender       = Gender.female,
                    HospitalName = "Medicana Sisli",
                    HospitalId   = 150,
                    SpecialtyId  = 20746,
                    BranchId     = 19747.48,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 6,
                    CreatedAt    = DateTime.Parse("2021-07-28T13:55:08.598Z"),
                    Name         = "Elena Morissette",
                    Gender       = Gender.female,
                    HospitalName = "Memorial",
                    HospitalId   = 54892,
                    SpecialtyId  = 88071,
                    BranchId     = 94982.39,
                    Nationality  = "DE",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 7,
                    CreatedAt    = DateTime.Parse("2021-06-14T18:01:30.325Z"),
                    Name         = "Hamdi Öztürk",
                    Gender       = Gender.male,
                    HospitalName = "Medicana Sisli",
                    HospitalId   = 23701,
                    SpecialtyId  = 9090,
                    BranchId     = 19747.48,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 8,
                    CreatedAt    = DateTime.Parse("2021-08-27T04:04:58.976Z"),
                    Name         = "Craig O'Keefe",
                    Gender       = Gender.male,
                    HospitalName = "American Hospital",
                    HospitalId   = 58497,
                    SpecialtyId  = 39708,
                    BranchId     = 46998.74,
                    Nationality  = "USA",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 9,    
                    CreatedAt    = DateTime.Parse("2022-03-12T15:47:42.275Z"),
                    Name         = "Aysun Çoşkun",
                    Gender       = Gender.female,
                    HospitalName = "Ege Hastanesi",
                    HospitalId   = 1058,
                    SpecialtyId  = 82688,
                    BranchId     = 5663.64,
                    Nationality  = "TUR",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                },new()
                {
                    Id = 10,
                    CreatedAt    = DateTime.Parse("2022-05-09T19:12:58.359Z"),
                    Name         = "Cesar Batz",
                    Gender       = Gender.male,
                    HospitalName = "Ege Hastanesi",
                    HospitalId   = 1058,
                    SpecialtyId  = 13798,
                    BranchId     = 5663.64,
                    Nationality  = "ITA",
                    Status       = DataStatus.Inserted,
                    CreatedDate  = DateTime.Now
                }
            });
        }
    }
}
