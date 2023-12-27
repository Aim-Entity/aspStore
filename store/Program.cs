using Microsoft.EntityFrameworkCore;
using store.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IImageRepository, ImageRepository>();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration["ConnectionStrings:StoreDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

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

app.MapDefaultControllerRoute();

app.Run();
