#pragma checksum "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\ConfirmDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c53e8b8579e1f8459c98e00c2742d732af1e292"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyWaySO.Pages.Admin.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using MyWaySO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using MyWaySO.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\ConfirmDialog.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class ConfirmDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\ConfirmDialog.razor"
       
    private Dictionary<string, object> cdBtnConfig(string title, string ddismiss)
    {
        var btn = new Dictionary<string, object>()
        {
            { "title", title},
            { "data-dismiss", ddismiss}
        };

        return btn;
    }

    [Parameter]
    public Guid Id { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591