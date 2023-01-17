using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Contexts;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectPresentation.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Yapýlandýrdýk
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDAL, EfServiceDAL>();

builder.Services.AddScoped<IPersonesService, PersonelsManager>();
builder.Services.AddScoped<IPersonelsDAL, EfPersonelsDAL>();

builder.Services.AddScoped<INewsService,NewsManager>();
builder.Services.AddScoped<INewsDAL,EfNewsDAL>();

builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImageDAL, EfImageDAL>();

builder.Services.AddScoped<IAddressService, AddressManager>();
builder.Services.AddScoped<IAddressDAL, EfAddressDAL>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDAL, EfContactDAL>();

builder.Services.AddScoped<ISocialMediaService,SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDAL,EfSocialMediaDAL>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDAL, EfAboutDAL>();

builder.Services.AddScoped<IAdminsService, AdminsManager>();
builder.Services.AddScoped<IAdminsDAL, EfAdminsDAL>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDAL, EfProductDAL>();

builder.Services.AddDbContext<ProjeContext>();

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjeContext>().AddErrorDescriber<UserIdentityValidator>();

//builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ProjeContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Index";
});
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build(); config.Filters.Add(new AuthorizeFilter(policy));
});

//authorize iþlemi için bu kod bloðu yazýlmasý gerekiyor
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser().
//    Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//});
//builder.Services.AddMvc();

//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {
//        x.LoginPath = "/Login/Index/";
//    });
// Kod Buraya kadar





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

app.UseAuthentication();//bu autohentication için gerekli olan bir kod

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
