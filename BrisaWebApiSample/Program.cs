using BrisaWebApiSample.Models;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddControllers()
    .AddFluentValidation();



//AddScoped, AddTransient, AddSingleton
builder.Services.AddScoped<IValidator<Supplier>, SupplierValidator>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();

app.Run();

