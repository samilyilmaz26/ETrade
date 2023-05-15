using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using ETrade.Rep.Concretes;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the containerbuilder.Services.AddSession();
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Personel")));
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<ICategoriesRepos, CategoriesRepos>();
builder.Services.AddScoped<IFoodsRepos, FoodsRepos>();
builder.Services.AddScoped<IPropertiesRepos, PropertiesRepos>();
builder.Services.AddScoped<IOrderDetailsRepos, OrderDetailsRepos>();
builder.Services.AddScoped<IOrdersRepos, OrdersRepos>();
builder.Services.AddScoped<IUsersRepos, UsersRepos>();
builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<FoodsModel>(); 
builder.Services.AddScoped<PropertiesModel>();
builder.Services.AddScoped<Users>();
builder.Services.AddScoped<Orders>();
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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
