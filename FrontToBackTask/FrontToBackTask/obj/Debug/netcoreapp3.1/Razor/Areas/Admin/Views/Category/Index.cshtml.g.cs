#pragma checksum "C:\Users\murad\OneDrive\Рабочий стол\Новая папка\FrontToBackTask\FrontToBackTask\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ead517a2604ab9f1a4428d2603d8dc273be3a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\murad\OneDrive\Рабочий стол\Новая папка\FrontToBackTask\FrontToBackTask\Areas\Admin\Views\_ViewImports.cshtml"
using FrontToBackTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ead517a2604ab9f1a4428d2603d8dc273be3a5", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0651a30926dd0c1564119c32f5827db3f0740d44", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <a class=""btn btn-primary mb-4"" href=""/admin"">Go Back</a>
                    <h4 class=""card-title"">Categories</h4>
                    <div class=""table-responsive"">
                        <table class=""table table-striped"">
                            <tbody>
");
#nullable restore
#line 13 "C:\Users\murad\OneDrive\Рабочий стол\Новая папка\FrontToBackTask\FrontToBackTask\Areas\Admin\Views\Category\Index.cshtml"
                                 for (int i = 0; i < Model.Count; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 17 "C:\Users\murad\OneDrive\Рабочий стол\Новая папка\FrontToBackTask\FrontToBackTask\Areas\Admin\Views\Category\Index.cshtml"
                                       Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            <button type=""button"" class=""btn btn-primary"">Details</button>
                                            <button type=""button"" class=""btn btn-warning"">Update</button>
                                            <button type=""button"" class=""btn btn-danger"">Delete</button>
                                        </td>
                                    </tr>
");
#nullable restore
#line 25 "C:\Users\murad\OneDrive\Рабочий стол\Новая папка\FrontToBackTask\FrontToBackTask\Areas\Admin\Views\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
