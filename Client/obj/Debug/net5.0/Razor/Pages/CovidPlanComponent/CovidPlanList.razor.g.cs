#pragma checksum "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f68f3de758323909969a5058b39cc9dd5e431d23"
// <auto-generated/>
#pragma warning disable 1591
namespace SVSignalR.Client.Pages.CovidPlanComponent
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
#line 3 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
using SVSignalR.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
using SVSignalR.Shared.AppData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/covidplanlist")]
    public partial class CovidPlanList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Covid Plan Detail</h3>\r\n");
            __builder.OpenComponent<AntDesign.Spin>(1);
            __builder.AddAttribute(2, "Spinning", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                _loading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<p><a href=\"/addcovidplan\">Create A New Record</a></p>");
#nullable restore
#line 18 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
     if (cvPlans == null || cvPlans.Count() == 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Empty>(5);
                __builder2.AddAttribute(6, "Simple", true);
                __builder2.CloseComponent();
#nullable restore
#line 21 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.Table<CovidPlanModel>>(7);
                __builder2.AddAttribute(8, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CovidPlanModel>>(
#nullable restore
#line 24 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                   cvPlans

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ScrollY", "400px");
                __builder2.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                         50

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ScrollX", "1550");
                __builder2.AddAttribute(12, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.TableSize>(
#nullable restore
#line 26 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                      TableSize.Small

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<CovidPlanModel>)((context) => (__builder3) => {
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_0(__builder3, 15, 16, "WorkerId", 17, "100", 18, 
#nullable restore
#line 28 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                    , 19, 
#nullable restore
#line 28 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                               context.WorkerId

#line default
#line hidden
#nullable disable
                    , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.WorkerId = __value, context.WorkerId)), 21, () => context.WorkerId);
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_1(__builder3, 23, 24, "FullName", 25, "200", 26, 
#nullable restore
#line 29 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                               context.FullName

#line default
#line hidden
#nullable disable
                    , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.FullName = __value, context.FullName)), 28, () => context.FullName);
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_2(__builder3, 30, 31, "Section", 32, "200", 33, 
#nullable restore
#line 30 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                    , 34, 
#nullable restore
#line 30 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                              context.SectionName

#line default
#line hidden
#nullable disable
                    , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.SectionName = __value, context.SectionName)), 36, () => context.SectionName);
                    __builder3.AddMarkupContent(37, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_3(__builder3, 38, 39, "Line", 40, "200", 41, 
#nullable restore
#line 31 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                    , 42, 
#nullable restore
#line 31 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                           context.LineName

#line default
#line hidden
#nullable disable
                    , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.LineName = __value, context.LineName)), 44, () => context.LineName);
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_4(__builder3, 46, 47, "PhoneNumber", 48, "150", 49, 
#nullable restore
#line 32 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                                  context.PhoneNumber

#line default
#line hidden
#nullable disable
                    , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.PhoneNumber = __value, context.PhoneNumber)), 51, () => context.PhoneNumber);
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_5(__builder3, 53, 54, "Detail", 55, "200", 56, 
#nullable restore
#line 33 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                             context.AddressDetail

#line default
#line hidden
#nullable disable
                    , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.AddressDetail = __value, context.AddressDetail)), 58, () => context.AddressDetail);
                    __builder3.AddMarkupContent(59, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_6(__builder3, 60, 61, "Address", 62, "400", 63, 
#nullable restore
#line 34 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                              context.AddressDisplay

#line default
#line hidden
#nullable disable
                    , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.AddressDisplay = __value, context.AddressDisplay)), 65, () => context.AddressDisplay);
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_7(__builder3, 67, 68, "Status", 69, "100", 70, 
#nullable restore
#line 35 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                             context.HealthStatus

#line default
#line hidden
#nullable disable
                    , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.HealthStatus = __value, context.HealthStatus)), 72, () => context.HealthStatus);
                    __builder3.AddMarkupContent(73, "\r\n            ");
                    __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList.TypeInference.CreateColumn_8(__builder3, 74, 75, "Time", 76, "100", 77, "yyyy/MM/dd", 78, 
#nullable restore
#line 36 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
                                                           context.CreatedTime

#line default
#line hidden
#nullable disable
                    , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.CreatedTime = __value, context.CreatedTime)), 80, () => context.CreatedTime);
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 38 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Pages\CovidPlanComponent\CovidPlanList.razor"
       
    private bool _loading = true;
    CovidPlanModel[] cvPlans;

    AddressModel[] addresses;
    WorkerModel[] workers;
    
    string msg;

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
        _loading = true;
        
        cvPlans = await Http.GetFromJsonAsync<CovidPlanModel[]>("api/covidplans");
        addresses = await Http.GetFromJsonAsync<AddressModel[]>("api/addresses");
        workers = await Http.GetFromJsonAsync<WorkerModel[]>("api/workers");

        workerAddressState.Addresses = addresses;
        workerAddressState.Workers = workers;

        msg = $"Success:{JsonSerializer.Serialize(cvPlans)}";

        _loading = false;

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WorkerAddressState workerAddressState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.SVSignalR.Client.Pages.CovidPlanComponent.CovidPlanList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Sortable", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_2<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Sortable", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateColumn_3<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Sortable", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateColumn_4<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_5<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_6<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_7<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_8<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Format", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
