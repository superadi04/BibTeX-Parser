#pragma checksum "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a4632e77b921c4faf92f8ab2b26ea1fd6b9c05"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppparser.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using BlazorAppparser.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\_Imports.razor"
using BlazorAppparser.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\Pages\FetchData.razor"
using BlazorAppparser.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\adity\OneDrive\Documents\GitHub\BhaviCode\BibtexParser\BlazorAppparser\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
