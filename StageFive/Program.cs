using StageFive.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCustomServices();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );
app.MapControllers();
app.Run();
