using AutoMapper.Internal.Mappers;
using DocPlannerStudyCase.Models.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DocPlannerStudyCase.Models.Entities
{
    public class Doctor : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string HospitalName { get; set; }
        public int HospitalId { get; set; }
        public int SpecialtyId { get; set; }
        public double BranchId { get; set; }
        public string Nationality { get; set; }
    }
}
