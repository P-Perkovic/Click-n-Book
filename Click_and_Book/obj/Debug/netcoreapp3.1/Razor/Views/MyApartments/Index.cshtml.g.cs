#pragma checksum "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20dccefb737cfd28d1e047c50fcca3e478988d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyApartments_Index), @"mvc.1.0.view", @"/Views/MyApartments/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\Project_zoraja\Click_and_Book\Views\_ViewImports.cshtml"
using Click_and_Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Project_zoraja\Click_and_Book\Views\_ViewImports.cshtml"
using Click_and_Book.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dccefb737cfd28d1e047c50fcca3e478988d66", @"/Views/MyApartments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7268f8d133edd4f7d3106426a410050f42ec9bfc", @"/Views/_ViewImports.cshtml")]
    public class Views_MyApartments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Click_and_Book.ViewModels.MyApartmantsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"margin-top: 50px\">\r\n    <a type=\"button\" class=\"btn btn-danger\" href=\"MyApartments/New\">Add Apartment</a>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
 if (Model.Apartments.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
     foreach (var apartmentRez in Model.Apartments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\" style=\"background-color: darkgrey\">\r\n                <div class=\"col-lg\">\r\n                    <div class=\"container\">\r\n                        <div class=\"carousel\">\r\n");
#nullable restore
#line 23 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                              int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                             foreach (var image in apartmentRez.Apartment.Images)
                            {
                                if (i == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 867, "\"", 910, 4);
            WriteAttributeValue("", 872, "carousel_", 872, 9, true);
#nullable restore
#line 28 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 881, apartmentRez.Apartment.Id, 881, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 907, "-", 907, 1, true);
#nullable restore
#line 28 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 908, i, 908, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"carousel[]\" checked>\r\n");
#nullable restore
#line 29 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 1103, "\"", 1146, 4);
            WriteAttributeValue("", 1108, "carousel_", 1108, 9, true);
#nullable restore
#line 32 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 1117, apartmentRez.Apartment.Id, 1117, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1143, "-", 1143, 1, true);
#nullable restore
#line 32 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 1144, i, 1144, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"carousel[]\">\r\n");
#nullable restore
#line 33 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                }
                                i++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul class=\"carousel__items\">\r\n");
#nullable restore
#line 37 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                 foreach (var image in apartmentRez.Apartment.Images)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"carousel__item\">  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "20dccefb737cfd28d1e047c50fcca3e478988d668069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1527, "~/ApartmentImages/", 1527, 18, true);
#nullable restore
#line 39 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
AddHtmlAttributeValue("", 1545, image.ImageName, 1545, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 40 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            <div class=\"carousel__prev\">\r\n");
#nullable restore
#line 43 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                   i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                 foreach (var image in apartmentRez.Apartment.Images)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label");
            BeginWriteAttribute("for", " for=\"", 1936, "\"", 1980, 4);
            WriteAttributeValue("", 1942, "carousel_", 1942, 9, true);
#nullable restore
#line 46 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 1951, apartmentRez.Apartment.Id, 1951, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1977, "-", 1977, 1, true);
#nullable restore
#line 46 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 1978, i, 1978, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n");
#nullable restore
#line 47 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"carousel__next\">\r\n");
#nullable restore
#line 51 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                   i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                 foreach (var image in apartmentRez.Apartment.Images)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label");
            BeginWriteAttribute("for", " for=\"", 2371, "\"", 2415, 4);
            WriteAttributeValue("", 2377, "carousel_", 2377, 9, true);
#nullable restore
#line 54 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 2386, apartmentRez.Apartment.Id, 2386, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2412, "-", 2412, 1, true);
#nullable restore
#line 54 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 2413, i, 2413, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n");
#nullable restore
#line 55 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"carousel__nav\">\r\n");
#nullable restore
#line 59 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                   i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                 foreach (var image in apartmentRez.Apartment.Images)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label");
            BeginWriteAttribute("for", " for=\"", 2805, "\"", 2849, 4);
            WriteAttributeValue("", 2811, "carousel_", 2811, 9, true);
#nullable restore
#line 62 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 2820, apartmentRez.Apartment.Id, 2820, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2846, "-", 2846, 1, true);
#nullable restore
#line 62 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 2847, i, 2847, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n");
#nullable restore
#line 63 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <div class=\"form-group\">\r\n                        <h2>");
#nullable restore
#line 71 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                       Write(apartmentRez.Apartment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Price par night: ");
#nullable restore
#line 74 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                       Write(apartmentRez.Apartment.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kn</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Number of beds: ");
#nullable restore
#line 77 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                      Write(apartmentRez.Apartment.NumBeds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Number of rooms: ");
#nullable restore
#line 80 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                       Write(apartmentRez.Apartment.NumRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Number of guests: ");
#nullable restore
#line 83 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                        Write(apartmentRez.Apartment.MaxPeople);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Stars: ");
#nullable restore
#line 86 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                             Write(apartmentRez.Apartment.NumStars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 88 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                     if (apartmentRez.Apartment.Balcony == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <p>Balcony</p>\r\n                        </div>\r\n");
#nullable restore
#line 93 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                     if (apartmentRez.Apartment.AirConditioner == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <p>Air Condition</p>\r\n                        </div>\r\n");
#nullable restore
#line 99 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <p>Category: ");
#nullable restore
#line 101 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                Write(apartmentRez.Apartment.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>Address: ");
#nullable restore
#line 104 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                               Write(apartmentRez.Apartment.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <p>City Block: ");
#nullable restore
#line 107 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                  Write(apartmentRez.Apartment.CityBlock.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 109 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                     if(apartmentRez.Reservations.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>Active Reservations</h5>\r\n");
#nullable restore
#line 112 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                         foreach (var reserv in apartmentRez.Reservations)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Invoice# ");
#nullable restore
#line 114 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                   Write(reserv.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 114 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                               Write(reserv.TimeFrom.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 114 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                                                                      Write(reserv.TimeTo.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 115 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                 if (reserv.IsApproved == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 5488, "\"", 5526, 2);
            WriteAttributeValue("", 5495, "Reservations/Approve/", 5495, 21, true);
#nullable restore
#line 117 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 5516, reserv.Id, 5516, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Approve</a>\r\n");
#nullable restore
#line 118 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n");
#nullable restore
#line 120 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>No reservations yet</h5>\r\n");
#nullable restore
#line 125 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"margin-top: 50px\">\r\n                        <a type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 5901, "\"", 5952, 2);
            WriteAttributeValue("", 5908, "MyApartments/Edit/", 5908, 18, true);
#nullable restore
#line 127 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 5926, apartmentRez.Apartment.Id, 5926, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Apartment</a>\r\n                        <a type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 6037, "\"", 6090, 2);
            WriteAttributeValue("", 6044, "MyApartments/Delete/", 6044, 20, true);
#nullable restore
#line 128 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
WriteAttributeValue("", 6064, apartmentRez.Apartment.Id, 6064, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Apartment</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 134 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>You don\'t have apartment yet!</h4>\r\n");
#nullable restore
#line 139 "D:\Projects\Project_zoraja\Click_and_Book\Views\MyApartments\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Click_and_Book.ViewModels.MyApartmantsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
