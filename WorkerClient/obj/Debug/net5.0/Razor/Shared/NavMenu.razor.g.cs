#pragma checksum "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fdacfcae1585da83e70243330d18f8856dc377c"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkerClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using WorkerClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\_Imports.razor"
using WorkerClient.Shared;

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
            __builder.AddAttribute(2, "b-ki3d2atk8f");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-ki3d2atk8f>WorkerClient</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-ki3d2atk8f");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-ki3d2atk8f></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-ki3d2atk8f");
            __builder.AddMarkupContent(14, "<ul class=\"nav flex-column\" b-ki3d2atk8f></ul>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Shared\NavMenu.razor"
       
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
