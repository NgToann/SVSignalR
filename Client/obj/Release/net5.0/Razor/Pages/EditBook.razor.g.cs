#pragma checksum "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f05ce2aa3a8280f7215f03719abdedf2d0f84b"
// <auto-generated/>
#pragma warning disable 1591
namespace SVSignalR.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using SVSignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using SVSignalR.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
using SVSignalR.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editbook/{id}")]
    public partial class EditBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Book</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "for", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                               book.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Name = __value, book.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Department\" class=\"control-label\">ISBN</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "for", "Department");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                                     book.Isbn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Isbn = __value, book.Isbn));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Designation\" class=\"control-label\">Author</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "for", "Designation");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                                      book.Author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Author = __value, book.Author));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"Company\" class=\"control-label\">Price</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "for", "Company");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                                  book.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Price = __value, book.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                                    UpdateBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\EditBook.razor"
       

    private HubConnection hubConnection;
    [Parameter]
    public string id { get; set; }

    BookModel book = new BookModel();

    protected override async Task OnInitializedAsync()
    {
        book = await Http.GetFromJsonAsync<BookModel>("api/BookModels/" + id);

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        await hubConnection.StartAsync();
    }

    protected async Task UpdateBook()
    {
        await Http.PutAsJsonAsync("api/BookModels/" + id, book);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("listbooks");
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listbooks");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591