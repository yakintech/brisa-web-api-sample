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


//94.73.170.48
//dbBB8
//userBB8
//HYp58-_c9hC7zF_-

//Core, SQL Server, Tools

//add-migration 

