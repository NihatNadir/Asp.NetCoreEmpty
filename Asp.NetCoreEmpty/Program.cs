var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // API kullanmadan devam edeceðimiz için bu metodu kullanýyoruz.

var app = builder.Build();

app.UseStaticFiles(); // wwwroot için gereken metot




app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Home}/{action=Index}" // Homecontroller içerisindeki Index action istek atar. Default routing
    );

app.Run();


// Controller: Kullanýcý taleplerini iþleyen ve model ile view arasýnda köprü görevi gören sýnýf.
// Action: Controller içindeki bir metod olup, bir isteði iþler ve sonuç döndürür (View, Json, Redirect vb.).
// Model: Uygulamanýn veri yapýsýný temsil eden sýnýflardýr. Veriler genellikle veritabaný ya da dýþ kaynaklardan gelir.
// View: Kullanýcýya sunulan HTML içeriðini oluþturan dosyalardýr. Genellikle Razor kullanýlarak yazýlýr.
// Razor: HTML ve C# kodlarýný birlikte yazmak için kullanýlan bir view motorudur.
// RazorView: Razor motoru tarafýndan oluþturulan, HTML sayfasý ile C# kodunu birleþtiren bir view dosyasýdýr (.cshtml).
// wwwroot: Statik dosyalarýn (CSS, JavaScript, resimler vb.) bulunduðu klasördür. Tarayýcýya doðrudan sunulur.
// builder ile uygulamanýn yapýlandýrýlmasý yapýlýr (servisler, middleware'ler vb.).
// builder.Build() ile yapýlandýrýlmýþ olan uygulama nesnesi oluþturulur.
// app.Run() ile uygulama baþlatýlýr ve HTTP isteklerini dinlemeye baþlar.
