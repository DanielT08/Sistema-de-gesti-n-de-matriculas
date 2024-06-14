using solucion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication;
using solucion.Models;
using solucion.Services.Courses;
using solucion.Services.Enrollments;
using solucion.Services.Students;
using solucion.Services.Teachers;
using solucion.Repository.Courses;
using solucion.Repository.Enrollments;
using solucion.Repository.Students;
using solucion.Repository.Teachers;
using solucion.Utils;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers().AddJsonOptions(Options =>
    {
        Options.JsonSerializerOptions.PropertyNamingPolicy = null;
        Options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        Options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddDbContext<BaseContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
    )
);

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
