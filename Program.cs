using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using APITesting;
using APITesting.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped<HttpClient>();

builder.Services.AddScoped<ApiService>();

await builder.Build().RunAsync();
