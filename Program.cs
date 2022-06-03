var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddControllers();

var app = builder.Build();



app.UseRouting();


app.MapControllerRoute(
    name: "rotax",
    //pattern: "{controller=Home}/{action=Index}/{id?}",
    pattern: "categoria/{category}/{id?}",
    defaults: new { Controller = "Home", Action = "ListaDeCategorias" }
    );

app.MapControllerRoute(


    name: "padrao",
    //pattern: "{controller=Home}/{action=Index}/{id?}",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { Controller = "Home", Action = "Index"}
    );


app.Run();


//app.MapGet("/", () =>

//"Olá Vitat"
//);


//app.MapGet("/admin", (string username) =>

//"Olá Admin Vitat"+ username
//);




