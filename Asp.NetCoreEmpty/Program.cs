var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // API kullanmadan devam edece�imiz i�in bu metodu kullan�yoruz.

var app = builder.Build();

app.UseStaticFiles(); // wwwroot i�in gereken metot




app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Home}/{action=Index}" // Homecontroller i�erisindeki Index action istek atar. Default routing
    );

app.Run();


// Controller: Kullan�c� taleplerini i�leyen ve model ile view aras�nda k�pr� g�revi g�ren s�n�f.
// Action: Controller i�indeki bir metod olup, bir iste�i i�ler ve sonu� d�nd�r�r (View, Json, Redirect vb.).
// Model: Uygulaman�n veri yap�s�n� temsil eden s�n�flard�r. Veriler genellikle veritaban� ya da d�� kaynaklardan gelir.
// View: Kullan�c�ya sunulan HTML i�eri�ini olu�turan dosyalard�r. Genellikle Razor kullan�larak yaz�l�r.
// Razor: HTML ve C# kodlar�n� birlikte yazmak i�in kullan�lan bir view motorudur.
// RazorView: Razor motoru taraf�ndan olu�turulan, HTML sayfas� ile C# kodunu birle�tiren bir view dosyas�d�r (.cshtml).
// wwwroot: Statik dosyalar�n (CSS, JavaScript, resimler vb.) bulundu�u klas�rd�r. Taray�c�ya do�rudan sunulur.
// builder ile uygulaman�n yap�land�r�lmas� yap�l�r (servisler, middleware'ler vb.).
// builder.Build() ile yap�land�r�lm�� olan uygulama nesnesi olu�turulur.
// app.Run() ile uygulama ba�lat�l�r ve HTTP isteklerini dinlemeye ba�lar.
