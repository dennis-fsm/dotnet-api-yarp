using Bogus;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var faker = new Faker<User>().CustomInstantiator(
    f => new User(0, string.Empty, string.Empty))
    .RuleFor(u => u.Id, f => f.IndexGlobal)
    .RuleFor(u => u.FirstName, f => f.Person.FirstName)
    .RuleFor(u => u.LastName, f => f.Person.LastName);

var users = faker.Generate(100);

app.MapGet("/users", () =>
{
    return Results.Ok(users);
})
.WithName("GetUsers")
.WithOpenApi();

app.UseHttpsRedirection();

app.Run();

public record User(int Id, string FirstName, string LastName);

