using CustomerRelationshipManagement.Server;
using CustomerRelationshipManagement.Server.Data;
using CustomerRelationshipManagement.Server.Repo.RepoImplementation;
using CustomerRelationshipManagement.Server.Repo.RepoInterfaces;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<CRMDbContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("CRMDb")));

//builder.Services.AddDbContext<WCDbContext>(options =>
//      options.UseSqlite(builder.Configuration.GetConnectionString("CRMDb")));

builder.Services.AddTransient<IAdministration, Administration>();
//builder.Services.AddTransient<ILeadRepository, LeadRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
