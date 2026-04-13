
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //dùng mvc core
builder.Services.AddServices(); //đăng ký service vào DI container (thư mục Extensions)
builder.Services.AddSession(
    options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    }
  );

WebApplication app = builder.Build();
app.UseStaticFiles(); //dùng wwwroot
app.UseRouting();//dùng routing

//convention route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);

//attribute route 
app.MapControllers();

app.Run();
