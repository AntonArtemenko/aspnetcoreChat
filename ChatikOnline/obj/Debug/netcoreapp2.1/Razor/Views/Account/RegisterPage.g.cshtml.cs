#pragma checksum "C:\Users\Антон\source\repos\ChatikOnline\ChatikOnline\Views\Account\RegisterPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e15f26906632027f01336ac17db3ee6109bcd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterPage), @"mvc.1.0.view", @"/Views/Account/RegisterPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterPage.cshtml", typeof(AspNetCore.Views_Account_RegisterPage))]
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
#line 1 "C:\Users\Антон\source\repos\ChatikOnline\ChatikOnline\Views\_ViewImports.cshtml"
using ChatikOnline;

#line default
#line hidden
#line 2 "C:\Users\Антон\source\repos\ChatikOnline\ChatikOnline\Views\_ViewImports.cshtml"
using ChatikOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e15f26906632027f01336ac17db3ee6109bcd3", @"/Views/Account/RegisterPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ffb86acdabaf1ec1b0e479a3eb81e731381f02", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatikOnline.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 786, true);
            WriteLiteral(@"<h2>Регистрация нового пользователя</h2>
<div class=""col-6"">
    <for method=""post"">
        <input type=""text"" id=""loginInput"" />
        <br />
        <input type=""text"" id=""passwordInput"" />
        <input type=""button"" id=""registrateButton"" value=""Register"" />
    </for>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>

<script>
    $(document).ready(function () {
        $(""#registrateButton"").click(function () {
            $.ajax({
                type: ""POST"",
                url: ""Account/Registrate"",
                data: {
                    Login: $(""#loginInput"").val(),
                    Password: $(""#passwordInput"").val()
                }
            })
        });
    });
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatikOnline.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
