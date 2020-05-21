#pragma checksum "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\Posts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dacc9e4851123ebe7b8d781322a79bf3ff0c6a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazoR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using BlazoR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\_Imports.razor"
using BlazoR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\Posts.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/posts")]
    public partial class Posts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\Posts.razor"
       

    public string ChatState = "none";
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chatHub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("SendMessage", messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;


    private void OpenChat()
    {
        ChatState = "block";
    }

    private void CloseChat()
    {
        ChatState = "none";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591