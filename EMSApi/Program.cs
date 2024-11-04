
/*
 * 
 * 1. create web applicaion
 * 2. add services [Controllers, Database, Swagger, Vaidation framework, DI]
 * 3. configure serives
 * 
 */

using EMSApi.Data;
using EMSApi.Implementation;
using EMSApi.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddSingleton<ILogs, DBLogs>();
builder.Services.AddSingleton<EmployeStaticImp, EmployeStaticImp>();

builder.Services.AddDbContext<EMSDbContext>();
builder.Services.AddControllers(); 
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer(); // OAS - JSON File 
    builder.Services.AddSwaggerGen(); // UI - Application index.html
    builder.Services.AddLogging();

    

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger(); // swagger.json
        app.UseSwaggerUI(); // index.html
    }

    app.UseHttpsRedirection();// ssl self signed or thrid party signed verizone
    // middle wares
    /*app.UseAuthentication();
    app.UseAuthorization();
    app.UseHttpLogging();*/

    
    // asp.net framework will map this 
    app.MapControllers(); // method -> look for controllers folder where all the end points will be configured

    app.Run();
