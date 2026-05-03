using StageSeven.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddServices();

// BẬT SESSION
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

WebApplication app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// DÙNG SESSION
app.UseSession();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");
app.MapControllers();
app.Run();