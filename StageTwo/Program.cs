var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

// mặc định tìm kiếm file index.html, index.htm, default.html, default.html
app.UseDefaultFiles();

// dùng các file tĩnh css, js, image,... trong wwwroot
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}"
);

app.Run();


