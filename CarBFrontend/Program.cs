var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HATA GÖRMEK ÝÇÝN (ÖNEMLÝ)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// ?? STATIC FILES ÞART
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ?? MVC ROUTE
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
