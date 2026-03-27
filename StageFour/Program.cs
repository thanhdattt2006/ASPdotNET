var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();

// convention route
// localhost:xxxx/controller/action/id
// localhost:xxxx/home/index/1

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index1}/{fullname?}/{gender?}"
);

app.Run();
