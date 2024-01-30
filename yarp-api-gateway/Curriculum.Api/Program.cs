using Bogus;
using Bogus.DataSets;
using System.Runtime.CompilerServices;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


var faker = new Faker();
var course = Enumerable.Range(0, 100).Select(index => new { Id = index, Name = new Faker().Music.Genre() }).ToArray();

app.MapGet("/music-courses", () =>
{
    return Results.Ok(course);
})
.WithName("GetMusicCourses")
.WithOpenApi();


app.UseHttpsRedirection();


app.Run();
