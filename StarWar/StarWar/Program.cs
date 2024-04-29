using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Staris.Shared.Extensions;
using StarWar;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region IOCs
await builder.Services.AddIocSSR();
#endregion

await builder.Build().RunAsync();


