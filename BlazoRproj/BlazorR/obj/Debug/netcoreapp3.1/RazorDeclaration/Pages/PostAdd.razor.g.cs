#pragma checksum "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\PostAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f5812a4937934a412d9002e816e7242b668ac3"
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
#line 3 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\PostAdd.razor"
using BlazoR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\PostAdd.razor"
using BlazoR.Domain.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/postAdd")]
    public partial class PostAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Dima\source\repos\BlazorR\BlazoRproj\BlazorR\Pages\PostAdd.razor"
       
    private int currentImage = 0;
    private string Url;
    private string Header;
    private List<string> ImageUrls = new List<string>();
    private string Text;

    public void Create()
    {

        Post newPost = new Post()
        {
            Header = this.Header,
            Images = this.ImageUrls,
            Text = this.Text
        };

        Header = "";
        ImageUrls = new List<string>();
        Text = "";
        PostService.CreatePost(newPost);
    }

    public void CreateNewImageInput()
    {
        ImageUrls.Add(Url);
        Url = "";
    }

    public void DeleteLastImageInput()
    {
        ImageUrls.Remove(ImageUrls.Last());
    }

    private void PreviousImage()
    {
        if (currentImage > 0)
        {
            currentImage--;
        }
        else
        {
            currentImage = ImageUrls.Count - 1;
        }
    }

    private void NextImage()
    {
        if (currentImage < ImageUrls.Count - 1)
        {
            currentImage++;
        }
        else
        {
            currentImage = 0;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PostService PostService { get; set; }
    }
}
#pragma warning restore 1591