var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();


var app = builder.Build();

//Use static files, para rotear el css y las img
app.UseStaticFiles();

//Usar el ruteo
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute()); 

app.Run();
