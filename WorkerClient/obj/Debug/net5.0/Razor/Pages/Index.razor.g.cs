#pragma checksum "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ea048e9bfa9fe2e54ffd72a18844b0888a6586"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkerClient.Pages
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
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
using WorkerClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Orders</h3>");
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
 if (orders == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
}
else if (!orders.Any()) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>loading menu.....</em></p>");
#nullable restore
#line 17 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>items</th>\r\n            <th>adress</th>\r\n            <th><h7 style=\"color:tomato;\">\r\n                    🗑️\r\n                </h7></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 33 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
         foreach (var item in orders)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
                                                  () => Ding()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, 
#nullable restore
#line 38 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
                         item.items

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
                                                  () => Ding()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 43 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
                         item.adr

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
                                                  () => Ding()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "<h7 style=\"color:tomato;\">\r\n                            -remove-\r\n                        </h7>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                \r\n                <td></td>");
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Bruger\RiderProjects\WorkerClient\WorkerClient\Pages\Index.razor"
       
    private static string listuri = "http://localhost:8080/orders/";
    private static int x = 0;
    static OrderObject oItem = new OrderObject();
    IList<OrderObject> orders = new Collection<OrderObject>();
    OrderObject o = new OrderObject();

    
    protected override async Task OnInitializedAsync()
    {
        
    //orderes.Clear();
        /*for (int x = 1;tst.ReceiveOrdersAsync(x) != null; x++)
        {
            orders.Add(await tst.ReceiveOrdersAsync(x));
        }*/

        try {
            if (tst.ReceiveOrdersAsync(x) != null)
            {
                for (int x = 0; tst.ReceiveOrdersAsync(x) != null; x++)
                {
                    orders.Add(await tst.ReceiveOrdersAsync(x));
                }
                
            }
            
        }catch(Exception e){}
        
    }


    public void Ding()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITest tst { get; set; }
    }
}
#pragma warning restore 1591
