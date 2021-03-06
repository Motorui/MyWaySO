#pragma checksum "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd46d4fd8e3e469b7dbe000ba19c783b89793de"
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
#line 1 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor"
using MyWaySO.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor"
using MyWaySO.Areas.Identity.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class UhModal___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\ruisa\source\repos\MyWaySO\MyWaySO\Pages\Admin\Components\UhModal - Copy.razor"
       
        private Dictionary<string, object> uhMBtnConfig(string type, string title, string ddismiss)
        {
            var btn = new Dictionary<string, object>()
        {
            {"type", type},
            { "title", title},
            { "data-dismiss", ddismiss}
        };

        return btn;
    }

    SfToast ToastObj;

    private int ToastFlag = 0;
    private string ToastTitle = "";
    private string ToastContent = "";
    private string ToastCssClass = "";
    private string ToastIcon = "";

    private ToastOption[] Toasts = new ToastOption[]
{
        new ToastOption{ Title = "Sucesso!", Content="UH criada com sucesso.", CssClass="e-toast-success", Icon="e-success toast-icons" },
        new ToastOption{ Title = "Sucesso!", Content="UH editada com sucesso.", CssClass="e-toast-success", Icon="e-success toast-icons" },
        new ToastOption{ Title = "Sucesso!", Content="UH apagada com sucesso.", CssClass="e-toast-info", Icon="e-info toast-icons" }
    };

    [Parameter]
    public Uh ModelUh { get; set; }

    [Parameter]
    public Action DataChanged { get; set; }

    [Parameter]
    public RenderFragment CustomHeader { get; set; }

    private async void HandleValidSubmit()
    {
        if (ModelUh.UhID == Guid.Empty)
        {
            _uhService.AddUh(ModelUh);
            ShowMsg(0);
        }
        else
        {
            _uhService.UpdateUh(ModelUh);
            ShowMsg(1);
        }

        await CloseUhModal("uhModal");
        DataChanged?.Invoke();
    }

    private async void ShowMsg(int msg)
    {
        this.ToastTitle = this.Toasts[msg].Title;
        this.ToastContent = this.Toasts[msg].Content;
        this.ToastCssClass = this.Toasts[msg].CssClass;
        this.ToastIcon = this.Toasts[msg].Icon;

        await Task.Delay(100);
        await this.ToastObj.Show();
    }

    private class ToastOption
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CssClass { get; set; }
        public string Icon { get; set; }
    }

    private async Task CloseUhModal(string modalId)
    {
        await _jsRuntime.InvokeAsync<object>("global.closeModal", modalId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUhService _uhService { get; set; }
    }
}
#pragma warning restore 1591
