﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using University.Persistence;
using University.Persistence.Data;
using University.Web.AutoMapperConfig;
using University.Web.Extensions;
using University.Web.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UniversityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityContext") ?? throw new InvalidOperationException("Connection string 'UniversityContext' not found.")));

// Add services to the container.

builder.Services.AddControllersWithViews();
//builder.Services.AddControllersWithViews(opt =>
//{
//    opt.Filters.Add(typeof(ModelStateIsValid));
//});
builder.Services.AddAutoMapper(typeof(UniversityMappings));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    await app.SeedDataAsync();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
