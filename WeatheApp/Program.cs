using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeatheApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// base address for pirate weather url
builder.Services.AddScoped(
        sp => new HttpClient { BaseAddress = new Uri("https://api.pirateweather.net/forecast/") }
        );

builder.Configuration.AddJsonFile("appsettings.json", optional:true);

await builder.Build().RunAsync();
