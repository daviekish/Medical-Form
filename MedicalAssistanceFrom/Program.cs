using Domain_Layer.Data;
using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository_Layer;
using Service_Layer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<MedicalFormDbContext>();
builder.Services.AddScoped<MedicalFromModel>();
builder.Services.AddScoped<Files>();

builder.Services.AddDbContext<MedicalFormDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserService<MedicalFromModel>, UserService<MedicalFromModel>>();

builder.Services.AddScoped<IRepository<MedicalFromModel>, Repository<MedicalFromModel>>();

builder.Services.AddScoped<IFilesService<Files>, FilesService<Files>>();

builder.Services.AddScoped<IRepository<Files>, Repository<Files>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
