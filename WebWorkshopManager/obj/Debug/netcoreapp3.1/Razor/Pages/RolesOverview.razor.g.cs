#pragma checksum "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1073ae66127cec7b9291cfa4b6c5e3d43cf78fa3"
// <auto-generated/>
#pragma warning disable 1591
namespace WebWorkshopManager.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using WebWorkshopManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using WebWorkshopManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using WpfGridLayout.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
using BobbysUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class RolesOverview : RolesOverviewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatHeadline4>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "Роли");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MatBlazor.MatDivider>(4);
            __builder.AddAttribute(5, "Style", "margin: 10px auto;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 10 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
 if (this.TableItems == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenComponent<MatBlazor.MatProgressBar>(8);
            __builder.AddAttribute(9, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __Blazor.WebWorkshopManager.Web.Pages.RolesOverview.TypeInference.CreateMatTable_0(__builder, 12, 13, 
#nullable restore
#line 17 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                      TableItems

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 18 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                       true

#line default
#line hidden
#nullable disable
            , 15, "Name", 16, "Търсене по име", 17, "Име", 18, 
#nullable restore
#line 22 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                    150

#line default
#line hidden
#nullable disable
            , 19, "Страница", 20, "Редове в страница", 21, "mat-elevation-z5", 22, (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "th");
                __builder2.OpenComponent<MatBlazor.MatButton>(25);
                __builder2.AddAttribute(26, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                     AddNewRow

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                       MatIconNames.Add

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "Нова роля");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<th>Име</th>\r\n            ");
                __builder2.AddMarkupContent(32, "<th>Права</th>\r\n        ");
            }
            , 33, (context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "td");
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "style", "width: 133px;");
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(40);
                __builder2.AddAttribute(41, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                          MatIconNames.Edit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                        _ => OpenEditDialog(@context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(44);
                __builder2.AddAttribute(45, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                          MatIconNames.Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                          _ => DeleteRowAsync(@context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "style", "min-width: 133px;");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddContent(55, 
#nullable restore
#line 40 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                     context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "td");
                __builder2.AddContent(60, 
#nullable restore
#line 43 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                 EnumHelper.GetDisplayNamesFromFlags(context.Permissions).Join(", ")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(62, "\r\n");
            __builder.AddContent(63, "    ");
            __builder.OpenComponent<MatBlazor.MatDialog>(64);
            __builder.AddAttribute(65, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                              IsEditRowDialogOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsEditRowDialogOpen = __value, IsEditRowDialogOpen))));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, 
#nullable restore
#line 48 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                         DialogTitle

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(73);
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-4");
                    __builder3.AddMarkupContent(78, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(79);
                    __builder3.AddAttribute(80, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                 SelectedRowItemForEdit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 51 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                        SaveRowAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(83, "\r\n                    ");
                        __builder4.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(84);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(85, "\r\n\r\n                    ");
                        __builder4.OpenElement(86, "p");
                        __builder4.AddMarkupContent(87, "\r\n                        ");
                        __Blazor.WebWorkshopManager.Web.Pages.RolesOverview.TypeInference.CreateMatTextField_1(__builder4, 88, 89, "Име", 90, 
#nullable restore
#line 55 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                        , 91, 
#nullable restore
#line 55 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                                                                        true

#line default
#line hidden
#nullable disable
                        , 92, 
#nullable restore
#line 55 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                SelectedRowItemForEdit.Name

#line default
#line hidden
#nullable disable
                        , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedRowItemForEdit.Name = __value, SelectedRowItemForEdit.Name)), 94, () => SelectedRowItemForEdit.Name);
                        __builder4.AddMarkupContent(95, "\r\n                        ");
                        __Blazor.WebWorkshopManager.Web.Pages.RolesOverview.TypeInference.CreateValidationMessage_2(__builder4, 96, 97, 
#nullable restore
#line 56 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                  () => SelectedRowItemForEdit.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(98, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(99, "\r\n                    ");
                        __builder4.OpenComponent<MatBlazor.MatHeadline6>(100);
                        __builder4.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(102, "Права");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\r\n                    ");
                        __builder4.OpenComponent<MatBlazor.MatDivider>(104);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n");
#nullable restore
#line 60 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                     foreach (var item in PermissionCheckBoxItems)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(106, "                        ");
                        __builder4.OpenComponent<MatBlazor.MatCheckbox<bool>>(107);
                        __builder4.AddAttribute(108, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                           item.Label

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 62 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                                                     item.IsChecked

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.IsChecked = __value, item.IsChecked))));
                        __builder4.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => item.IsChecked));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\r\n");
#nullable restore
#line 63 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(113, "                    \r\n                    ");
                        __builder4.AddMarkupContent(114, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-4\">\r\n                    </div>\r\n                    ");
                        __builder4.OpenElement(115, "div");
                        __builder4.AddAttribute(116, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-4");
                        __builder4.AddMarkupContent(117, "\r\n                        ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(118);
                        __builder4.AddAttribute(119, "Icon", "cancel");
                        __builder4.AddAttribute(120, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                           CancelRowEditAsync

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(122, "Отказ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(123, "\r\n                        ");
                        __builder4.OpenComponent<MatBlazor.MatButton>(124);
                        __builder4.AddAttribute(125, "Icon", "save");
                        __builder4.AddAttribute(126, "Type", "submit");
                        __builder4.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(128, "Запази");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(129, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(130, "\r\n                    ");
                        __builder4.AddMarkupContent(131, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-4\">\r\n                    </div>\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n");
            __builder.AddContent(136, "    ");
            __builder.OpenComponent<MatBlazor.MatDialog>(137);
            __builder.AddAttribute(138, "Style", "z-index:100");
            __builder.AddAttribute(139, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                              IsDeleteRowDialogOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsDeleteRowDialogOpen = __value, IsDeleteRowDialogOpen))));
            __builder.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(142, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(143);
                __builder2.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(145);
                    __builder3.AddAttribute(146, "Icon", "warning");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(147, " Потвърдете изтриването");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(149);
                __builder2.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(151, "\r\n            Сигурни ли сте, че искате да изтриете \"");
                    __builder3.AddContent(152, 
#nullable restore
#line 81 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                                    SelectedRowItemForEdit.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(153, "\" ?\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(154, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(155);
                __builder2.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(157, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(158);
                    __builder3.AddAttribute(159, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                  e => { IsDeleteRowDialogOpen = false; }

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(161, "Отказ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(163);
                    __builder3.AddAttribute(164, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
                                 ConfirmDeleteRowAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(166, "Изтрии");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(167, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(168, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(169, "\r\n");
#nullable restore
#line 88 "D:\Student\Kursovi\WebWorkshopManager\WebWorkshopManager\Pages\RolesOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.WebWorkshopManager.Web.Pages.RolesOverview
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg10)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Striped", __arg1);
        __builder.AddAttribute(__seq2, "FilterByColumnName", __arg2);
        __builder.AddAttribute(__seq3, "SearchTermFieldLabel", __arg3);
        __builder.AddAttribute(__seq4, "SearchTermFieldPlaceHolder", __arg4);
        __builder.AddAttribute(__seq5, "DebounceMilliseconds", __arg5);
        __builder.AddAttribute(__seq6, "PageLabel", __arg6);
        __builder.AddAttribute(__seq7, "PageRecordCountLabel", __arg7);
        __builder.AddAttribute(__seq8, "class", __arg8);
        __builder.AddAttribute(__seq9, "MatTableHeader", __arg9);
        __builder.AddAttribute(__seq10, "MatTableRow", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Required", __arg1);
        __builder.AddAttribute(__seq2, "FullWidth", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591