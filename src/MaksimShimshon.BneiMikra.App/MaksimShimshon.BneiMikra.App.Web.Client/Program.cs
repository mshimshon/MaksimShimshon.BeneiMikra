using MaksimShimshon.BneiMikra.App.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddUIServices();

await builder.Build().RunAsync();
