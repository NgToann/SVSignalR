#pragma checksum "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67640d6d4616930fa5a77ecfa507b06291f22f4a"
// <auto-generated/>
#pragma warning disable 1591
namespace SVSignalR.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Layout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Header>(2);
                __builder2.AddAttribute(3, "Class", "site-layout-sub-header-background");
                __builder2.AddAttribute(4, "Style", "padding: 0; text-align:center;");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Row>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(8);
                        __builder4.AddAttribute(9, "Flex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 30 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                        "auto"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(11, "<h2 b-w61u7ywuhc>Saoviet Master Schedule</h2>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Layout>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Sider>(15);
                    __builder3.AddAttribute(16, "Style", "background-color: white; margin-top: 16px;");
                    __builder3.AddAttribute(17, "Breakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.BreakpointType>(
#nullable restore
#line 44 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                            BreakpointType.Lg

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                      250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "CollapsedWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "OnBreakpoint", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 47 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                             broken => { Console.WriteLine(broken); }

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(21, "OnCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                           collapsed => { Console.WriteLine(collapsed); }

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Layout>(23);
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Content>(25);
                            __builder5.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<AntDesign.Menu>(27);
                                __builder6.AddAttribute(28, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuTheme>(
#nullable restore
#line 53 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                                 MenuTheme.Light

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(29, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 53 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                                                        MenuMode.Inline

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<AntDesign.MenuItem>(31);
                                    __builder7.AddAttribute(32, "Key", "1");
                                    __builder7.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                                        __builder8.AddAttribute(35, "href", "");
                                        __builder8.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 55 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<AntDesign.Icon>(38);
                                            __builder9.AddAttribute(39, "Type", "home");
                                            __builder9.AddAttribute(40, "Theme", "outline");
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(41, "\r\n                                ");
                                            __builder9.AddMarkupContent(42, "<span class=\"nav-text\" b-w61u7ywuhc> Home</span>");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(43, "\r\n                        ");
                                    __builder7.OpenComponent<AntDesign.SubMenu>(44);
                                    __builder7.AddAttribute(45, "Key", "sub2");
                                    __builder7.AddAttribute(46, "TitleTemplate", new Microsoft.AspNetCore.Components.RenderFragment(
#nullable restore
#line 78 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                                                           outsoleTitle

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<AntDesign.MenuItem>(48);
                                        __builder8.AddAttribute(49, "RouterLink", "confirm-material");
                                        __builder8.AddAttribute(50, "Key", "7");
                                        __builder8.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<AntDesign.Icon>(52);
                                            __builder9.AddAttribute(53, "Type", "appstore-add");
                                            __builder9.AddAttribute(54, "Theme", "outline");
                                            __builder9.CloseComponent();
                                            __builder9.AddContent(55, " Confirm Material");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(56, "\r\n                            ");
                                        __builder8.OpenComponent<AntDesign.MenuItem>(57);
                                        __builder8.AddAttribute(58, "RouterLink", "release-material");
                                        __builder8.AddAttribute(59, "Key", "8");
                                        __builder8.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<AntDesign.Icon>(61);
                                            __builder9.AddAttribute(62, "Type", "block");
                                            __builder9.AddAttribute(63, "Theme", "outline");
                                            __builder9.CloseComponent();
                                            __builder9.AddContent(64, " Release Material");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(65, "\r\n                        ");
                                    __builder7.OpenComponent<AntDesign.MenuItem>(66);
                                    __builder7.AddAttribute(67, "RouterLink", "listbooks");
                                    __builder7.AddAttribute(68, "Key", "11");
                                    __builder7.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<AntDesign.Icon>(70);
                                        __builder8.AddAttribute(71, "Type", "wechat");
                                        __builder8.AddAttribute(72, "Theme", "outline");
                                        __builder8.CloseComponent();
                                        __builder8.AddContent(73, "List Books");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(74, "\r\n                        ");
                                    __builder7.OpenComponent<AntDesign.MenuItem>(75);
                                    __builder7.AddAttribute(76, "RouterLink", "covidplanlist");
                                    __builder7.AddAttribute(77, "Key", "13");
                                    __builder7.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<AntDesign.Icon>(79);
                                        __builder8.AddAttribute(80, "Type", "partition");
                                        __builder8.AddAttribute(81, "Theme", "outline");
                                        __builder8.CloseComponent();
                                        __builder8.AddContent(82, "Covid Plan List");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Layout>(84);
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Content>(86);
                        __builder4.AddAttribute(87, "Style", " margin: 16px 16px 0;");
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Card>(89);
                            __builder5.AddAttribute(90, "Style", "min-height: calc(100vh - 136px);");
                            __builder5.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(92, 
#nullable restore
#line 93 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(93, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Footer>(94);
                        __builder4.AddAttribute(95, "Style", "text-align: center; height:40px;");
                        __builder4.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(97, "Saoviet ©2021 Created by ItTeam Version 1.0");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n\r\n");
            __builder.AddMarkupContent(99, @"<style b-w61u7ywuhc>
    #components-layout-demo-responsive .logo {
        height: 32px;
        background: rgba(255, 255, 255, 0.2);
        margin: 16px;
    }

    .site-layout-sub-header-background {
        background: #fff;
    }

    .site-layout-background {
        background: #fff;
    }

    .avatar-item {
        margin-right: 24px;
    }

    [class*='-col-rtl'] .avatar-item {
        margin-right: 0;
        margin-left: 24px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
       
    EmbeddedProperty Property(int span, int offset) => new() { Span = span, Offset = offset };
    RenderFragment sub2Title =
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(100, "span");
            __builder2.AddAttribute(101, "b-w61u7ywuhc");
            __builder2.OpenComponent<AntDesign.Icon>(102);
            __builder2.AddAttribute(103, "Type", "schedule");
            __builder2.AddAttribute(104, "Theme", "outline");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(105, "\r\n        ");
            __builder2.AddMarkupContent(106, "<span b-w61u7ywuhc> Managment</span>");
            __builder2.CloseElement();
        }
#nullable restore
#line 11 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
           ;

RenderFragment outsoleTitle =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(107, "span");
            __builder2.AddAttribute(108, "b-w61u7ywuhc");
            __builder2.OpenComponent<AntDesign.Icon>(109);
            __builder2.AddAttribute(110, "Type", "sisternode");
            __builder2.AddAttribute(111, "Theme", "outline");
            __builder2.CloseComponent();
            __builder2.AddMarkupContent(112, "\r\n    ");
            __builder2.AddMarkupContent(113, "<span b-w61u7ywuhc> Outsole</span>");
            __builder2.CloseElement();
        }
#nullable restore
#line 17 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
       ;

private RenderFragment _text =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(114, "<span b-w61u7ywuhc>User: Admin</span>");
        }
#nullable restore
#line 19 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
                                                       ;

private RenderFragment _content =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(115, "div");
            __builder2.AddAttribute(116, "b-w61u7ywuhc");
            __builder2.OpenComponent<AntDesign.Button>(117);
            __builder2.AddAttribute(118, "Type", "primary");
            __builder2.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                __builder3.AddContent(120, "Logout !");
            }
            ));
            __builder2.CloseComponent();
            __builder2.CloseElement();
        }
#nullable restore
#line 24 "C:\Users\PhucNguyen\Desktop\ms-tut\SVSignalR\Client\Shared\MainLayout.razor"
      ;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
