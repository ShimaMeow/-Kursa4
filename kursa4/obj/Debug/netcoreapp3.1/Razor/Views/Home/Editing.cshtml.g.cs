#pragma checksum "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3aed0f32aa78a11b27d5eb3db640ca2ba905771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editing), @"mvc.1.0.view", @"/Views/Home/Editing.cshtml")]
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
#line 1 "C:\Users\79997\source\repos\kursa4\Views\_ViewImports.cshtml"
using kursova9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\79997\source\repos\kursa4\Views\_ViewImports.cshtml"
using kursova9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3aed0f32aa78a11b27d5eb3db640ca2ba905771", @"/Views/Home/Editing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3e35157eae1f3490361d0d403d2577cfbcca39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Editing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3aed0f32aa78a11b27d5eb3db640ca2ba9057714354", async() => {
                WriteLiteral("\r\n    <div class=\"input-group\" style=\"margin-top:20px\">\r\n        <span  class=\"input-group-text\">ФИО</span>\r\n        <input  type=\"text\" name=\"Surname\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 271, "\"", 303, 1);
#nullable restore
#line 8 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 279, ViewBag.Student.Surname, 279, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input  type=\"text\" name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 369, "\"", 398, 1);
#nullable restore
#line 9 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 377, ViewBag.Student.Name, 377, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input  type=\"text\" name=\"Patronymic\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 470, "\"", 505, 1);
#nullable restore
#line 10 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 478, ViewBag.Student.Patronymic, 478, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"row\" style=\"margin-top:25px\">\r\n        <div class=\"col\">\r\n            <label class=\"col-form-label\"></label>\r\n            <input  type=\"text\" name=\"State\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 714, "\"", 744, 1);
#nullable restore
#line 15 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 722, ViewBag.Student.State, 722, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col\">\r\n            <label  class=\"col-form-label\"></label>\r\n            <input  type=\"text\" name=\"Course\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 912, "\"", 943, 1);
#nullable restore
#line 19 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 920, ViewBag.Student.Course, 920, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col\">\r\n            <label for=\"Date\" class=\"col-form-label\"></label>\r\n            <input  type=\"date\" name=\"Date\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1119, "\"", 1171, 1);
#nullable restore
#line 23 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 1127, ViewBag.Student.Date.ToString("yyyy-MM-dd"), 1127, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        </div>
    </div>
    <div class=""row justify-content-end"">
        <div class=""col justify-content-end"" style=""margin-top:25px"">
            <button  type=""submit"" class=""btn btn-light"" style=""margin-left: 1005px;"">Сохранить</button>
        </div>
    </div>
    <input  type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 1488, "\"", 1515, 1);
#nullable restore
#line 31 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 1496, ViewBag.Student.id, 1496, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3aed0f32aa78a11b27d5eb3db640ca2ba9057719742", async() => {
                WriteLiteral("\r\n\t<a href=\"/Home/Index\" role=\"button\" class=\"btn btn-light\" style=\"margin-right: 950px\">Назад</a>\r\n\t<button style=\"margin-top: 20px\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1721, "\"", 1748, 1);
#nullable restore
#line 36 "C:\Users\79997\source\repos\kursa4\Views\Home\Editing.cshtml"
WriteAttributeValue("", 1729, ViewBag.Student.id, 1729, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" class=\"btn btn-light\">Удалить</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
