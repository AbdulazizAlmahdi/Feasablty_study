#pragma checksum "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8c43305d49809c73d8f7972c35f4f437df96bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feasibility_study_Details), @"mvc.1.0.view", @"/Views/Feasibility_study/Details.cshtml")]
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
#line 1 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Feasablty_study;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Feasablty_study.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8c43305d49809c73d8f7972c35f4f437df96bd", @"/Views/Feasibility_study/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f8f78b09a0e14c77f08661eda7af36e6972da1", @"/Views/_ViewImports.cshtml")]
    public class Views_Feasibility_study_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Feasablty_study.Models.Feasibility_study>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-label-success suspend-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
  
    ViewData["Title"] = "تعديل البيانات";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              <h3>تفاصيل العرض</h3>
                
                <hr />
             <div class=""row"">
              <div class=""authentication-wrapper authentication-basic container-p-y"">
                  <!-- User Card -->
               <div class=""authentication-inner py-4"">
                  <div class=""card"">
                    <div class=""card-body"">
                      <div class=""user-avatar-section"">
                        <div class=""d-flex flex-column align-items-center"">
                          <img class=""img-fluid rounded my-4"" src=""../../assets/img/avatars/details.jpg"" height=""110"" width=""110"" alt=""User avatar"">
                          <div class=""user-info text-center"">
                              <h4 class=""border-bottom pb-2 mb-4"">  عرض الدراسة</h4>
                            <h5 class=""mb-2"">");
#nullable restore
#line 20 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                          </div>
                        </div>
                      </div>
                      <hr />
                      <div class=""info-container"">
                           <ul class=""list-unstyled"">
                          <li class=""mb-3"">
                            <span class=""fw-bold me-2"">اسم المشروع:</span>
                            <span>");
#nullable restore
#line 29 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">وصف المشروع :</span>\r\n                            <span>");
#nullable restore
#line 33 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">موقع المشروع:</span>\r\n                            <span>");
#nullable restore
#line 37 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ProjectLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">نوع المشروع:</span>\r\n                            <span>");
#nullable restore
#line 41 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ProjectType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>                        \r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">  تاريخ بداية التنفيذ :</span>\r\n                            <span>");
#nullable restore
#line 45 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ProjectDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li><li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\"> رقم التواصل : </span>\r\n                            <span>");
#nullable restore
#line 48 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\النظام1\Feasablty study\Feasablty study\Views\Feasibility_study\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>                      \r\n                        </ul>\r\n\r\n                       <hr/>\r\n                <div class=\"d-flex justify-content-center pt-3\">\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb8c43305d49809c73d8f7972c35f4f437df96bd9214", async() => {
                WriteLiteral("عودة للقائمة ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>         \r\n                  </div>\r\n                   </div>\r\n                    </div>\r\n                      </div>\r\n                       </div>\r\n                        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Feasablty_study.Models.Feasibility_study> Html { get; private set; }
    }
}
#pragma warning restore 1591