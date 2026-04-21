


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //dùng mvc core
builder.Services.AddServices(); //đăng ký service vào DI container (thư mục Extensions)


//(***) khai báo cookie
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
      //nếu đăng nhập ko đúng thì quay về trang này
      options.LoginPath = "/Account/Login";
      options.AccessDeniedPath = "/Account/AccessDenied"; //nếu user đã đăng nhập nhưng ko có quyền truy cập thì quay về trang này
      options.ExpireTimeSpan = TimeSpan.FromHours(1);
      options.SlidingExpiration = true; //tự động gia hạn cookie nếu user hoạt động
    });

//(***) phải đăng nhập mới vào được tất cả các controller
builder.Services.AddAuthorizationBuilder()
  .SetFallbackPolicy(
    new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build()
  );


//(***) dùng session để lưu trữ thông tin đăng nhập của user
//yêu cầu cấp phát bộ nhớ để lưu trữ session
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession(
//    options =>
//    {
//      options.IdleTimeout = TimeSpan.FromMinutes(30);
//      options.Cookie.HttpOnly = true; //bảo mật cookie
//      options.Cookie.IsEssential = true;
//    }
//);

WebApplication app = builder.Build();
app.UseStaticFiles(); //dùng wwwroot
app.UseRouting();//dùng routing
app.UseAuthentication(); //kích hoạt authentication
app.UseAuthorization(); //kích hoạt authorization
//app.UseSession(); //kích hoạt session


//map cho admin area
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}"
);

//convention route client
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);

//attribute route 
app.MapControllers();

app.Run();
