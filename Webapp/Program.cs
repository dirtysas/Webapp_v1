using WebApp.BLL.Services;
using WebApp.DAL.Context;
using WebApp.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using WebApp.Web.Views.Home;
using WebApp.Web.Views.Home.Order;
using WebApp.Web.Views.Home.User;

var builder = WebApplication.CreateBuilder(args);

// ���������� ��������
builder.Services.AddControllersWithViews();

// ��������� ��������� ��
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ����������� ������������ � ��������
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();