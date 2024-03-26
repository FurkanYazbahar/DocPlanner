using AutoMapper;
using DocPlannerStudyCase.GenericRepository.ConcRep;
using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Mapper;
using DocPlannerStudyCase.Models.Context;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Services;
using DocPlannerStudyCase.Services.IServices;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{    
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<IRepository<Doctor>, DoctorRepository>();
builder.Services.AddScoped<IRepository<Schedule>, ScheduleRepository>();
builder.Services.AddScoped<IRepository<BookVisit>, BookVisitRepository>();

builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<BookVisitService>();
builder.Services.AddScoped<ScheduleService>();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
