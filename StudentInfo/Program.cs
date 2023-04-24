using Microsoft.EntityFrameworkCore;
using StudentInfo.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();



string cs = "Server=DESKTOP-H5LI7MM\\SQLEXPRESS;Database=StudentwithView;Trusted_Connection=True";
builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(cs));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=GetStudentList}/{id?}");

app.Run();
