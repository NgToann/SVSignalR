#pragma checksum "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1e4a90d600cfc9c88d3bb203c165a8b981f3e6"
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
#line 3 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
using SVSignalR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listbooks")]
    public partial class ListBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Book Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<p><a href=\"/addbook\">Create New Book</a></p>");
#nullable restore
#line 13 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
 if (books == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>Loading...</p>");
#nullable restore
#line 16 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Name</th>\r\n                <th>ISBN</th>\r\n                <th>Author</th>\r\n                <th>Price</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 29 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
             foreach (var book in books)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 32 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                         book.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 33 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                         book.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 34 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                         book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 35 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                         book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/editbook/" + (
#nullable restore
#line 37 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                                            book.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/deletebook/" + (
#nullable restore
#line 38 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
                                              book.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\ListBooks.razor"
       
    BookModel[] books;
    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        hubConnection.On("ReceiveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubConnection.StartAsync();

        await LoadData();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            await LoadData();
        });
    }

    protected async Task LoadData()
    {
        books = await Http.GetFromJsonAsync<BookModel[]>("api/BookModels");
        StateHasChanged();
    }

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591