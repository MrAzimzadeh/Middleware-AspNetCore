using Middleware_AspNetCore.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Use(async (context, next) =>
{
    Console.WriteLine("Start use midlaware");
    await next.Invoke(); //  ozunden sonra gelen middlaware kecmek uccun istifa de olunur ]
    Console.WriteLine("Stop use midlaware");

});
app.UseHello(); //  custom middle 

app.Use(async (context, next) =>
{
    Console.WriteLine("Start use midlaware");
    await next.Invoke(); //  ozunden sonra gelen middlaware kecmek uccun istifa de olunur ]
    Console.WriteLine("Stop use midlaware");

});

app.Use(async (context, next) =>
{
    Console.WriteLine("Start use midlaware");
    await next.Invoke(); //  ozunden sonra gelen middlaware kecmek uccun istifa de olunur ]
    Console.WriteLine("Stop use midlaware");

});


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run(/*async context => { Console.WriteLine("Run midlaware"); }*/); // middleware leri sonlandrirmaq ucun istifade olunur 

