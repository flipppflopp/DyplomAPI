using System.Linq;
using DB.DB_Context;
using DyplomAPI;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Services.Interfaces;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);

string connection = "Server=(localdb)\\mssqllocaldb;Database=dyplom_db;Trusted_Connection=True;";
// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options =>
options.UseSqlServer(connection));

builder.Services.AddScoped<IUserRepository, UserService>();
builder.Services.AddScoped<IAdvertisementRepository, AdvertisementService>();
builder.Services.AddScoped<IExpenseRepository, ExpenseService>();
builder.Services.AddScoped<IOrganizationRepository, OrganizationService>();
builder.Services.AddScoped<IOrganizationMemberRepository, OrganizationMemberService>();
builder.Services.AddScoped<IVolonteerInfoRepository, VolonteerInfoService>();



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
    
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();