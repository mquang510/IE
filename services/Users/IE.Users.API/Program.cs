using FluentValidation;
using FluentValidation.AspNetCore;
using IE.Shared.Persistence;
using IE.Users.Application.Data;
using IE.Users.Application.Interfaces;
using IE.Users.Application.Mapping;
using IE.Users.Application.Validators;
using IE.Users.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<ConfigMapper>());
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
