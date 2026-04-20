using StageSeven.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddServices();

WebApplication app = builder.Build();

app.UseStaticFiles();
//dùng route
app.UseRouting();
//map cho admin area
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}"
);
//convention 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");
//attribute route
app.MapControllers();
app.Run();
