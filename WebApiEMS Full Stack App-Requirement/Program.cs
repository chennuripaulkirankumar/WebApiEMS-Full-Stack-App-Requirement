﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiEMS_Full_Stack_App_Requirement.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EmpolyeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpolyeeContext") ?? throw new InvalidOperationException("Connection string 'EmpolyeeContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
