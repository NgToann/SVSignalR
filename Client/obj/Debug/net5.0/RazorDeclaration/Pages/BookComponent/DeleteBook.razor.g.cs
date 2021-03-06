// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SVSignalR.Client.Pages.BookComponent
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
#line 11 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\BookComponent\DeleteBook.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\BookComponent\DeleteBook.razor"
using SVSignalR.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletebook/{id}")]
    public partial class DeleteBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\BookComponent\DeleteBook.razor"
       

    [Parameter]
    public string id { get; set; }

    BookModel book = new BookModel();
    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        book = await Http.GetFromJsonAsync<BookModel>("api/BookModels/" + id);

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        await hubConnection.StartAsync();
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

    protected async Task Delete()
    {
        await Http.DeleteAsync("api/BookModels/" + id);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("listbooks");
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
