#pragma checksum "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f2cec3feb8c5733c656199929ff189563bc694"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazoR.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "a");
                __builder2.AddAttribute(14, "class", "navbar-brand");
                __builder2.AddAttribute(15, "href", "Identity/Account/Manage");
                __builder2.AddContent(16, 
#nullable restore
#line 8 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
                                                                        context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<form class=\"navbar-brand\" method=\"post\" action=\"Identity/Account/LogOut\">\r\n                    <button type=\"submit\" class=\"btn navbar-brand\" style=\"padding-bottom: 0px; padding-top: 0px;\">Выйти</button>\r\n                </form>\r\n            ");
            }
            ));
            __builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.AddMarkupContent(21, "<a class=\"navbar-brand\" href=\"Identity/Account/Register\">Регистрация</a>\r\n                ");
                __builder2.AddMarkupContent(22, "<a class=\"navbar-brand\" href=\"Identity/Account/Login\">Войти</a>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<a class=\"navbar-brand\" href>BlazoR</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", 
#nullable restore
#line 25 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "nav flex-column");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item px-3");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "");
            __builder.AddAttribute(40, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 28 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "postAdd");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Post Add\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(57);
            __builder.AddAttribute(58, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<BlazoR.Pages.Chat>(60);
                __builder2.AddAttribute(61, "CurrentUserName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
                                             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
