#pragma checksum "NestedScriptTagTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6bc8d09df124eda650118b208b7c5e6e058f6b"
namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class NestedScriptTagTagHelpers
    {
        #line hidden
        #pragma warning disable 0414
        private global::Microsoft.AspNet.Razor.TagHelperContent __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private global::Microsoft.AspNet.Razor.Runtime.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private global::Microsoft.AspNet.Razor.Runtime.TagHelperRunner __tagHelperRunner = null;
        private global::Microsoft.AspNet.Razor.Runtime.TagHelperScopeManager __tagHelperScopeManager = new global::Microsoft.AspNet.Razor.Runtime.TagHelperScopeManager();
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper = null;
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper = null;
        private global::TestNamespace.InputTagHelper2 __TestNamespace_InputTagHelper2 = null;
        #line hidden
        public NestedScriptTagTagHelpers()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            __tagHelperRunner = __tagHelperRunner ?? new global::Microsoft.AspNet.Razor.Runtime.TagHelperRunner();
            Instrumentation.BeginContext(33, 106, true);
            WriteLiteral("\r\n<script type=\"text/html\">\r\n    <div data-animation=\"fade\" class=\"randomNonTagHe" +
"lperAttribute\">\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNet.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                Instrumentation.BeginContext(180, 2, true);
                WriteLiteral("\r\n");
                Instrumentation.EndContext();
#line 6 "NestedScriptTagTagHelpers.cshtml"
            

#line default
#line hidden

#line 6 "NestedScriptTagTagHelpers.cshtml"
             for(var i = 0; i < 5; i++) {

#line default
#line hidden

                Instrumentation.BeginContext(225, 84, true);
                WriteLiteral("                <script id=\"nestedScriptTag\" type=\"text/html\">\r\n                 " +
"   ");
                Instrumentation.EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNet.Razor.TagHelpers.TagMode.StartTagOnly, "test", async() => {
                }
                , StartTagHelperWritingScope, EndTagHelperWritingScope);
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                StartTagHelperWritingScope();
                WriteLiteral("2000 + ");
#line 8 "NestedScriptTagTagHelpers.cshtml"
                                            Write(ViewBag.DefaultInterval);

#line default
#line hidden
                WriteLiteral(" + 1");
                __tagHelperStringValueBuffer = EndTagHelperWritingScope();
                __tagHelperExecutionContext.AddHtmlAttribute("data-interval", Html.Raw(__tagHelperStringValueBuffer.GetContent(HtmlEncoder)));
                __TestNamespace_InputTagHelper.Type = "text";
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __TestNamespace_InputTagHelper.Type);
                __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
#line 8 "NestedScriptTagTagHelpers.cshtml"
                                                          __TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked);
                __tagHelperExecutionContext.Output = await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                Instrumentation.BeginContext(309, 86, false);
                await WriteTagHelperAsync(__tagHelperExecutionContext);
                Instrumentation.EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                Instrumentation.BeginContext(395, 29, true);
                WriteLiteral("\r\n                </script>\r\n");
                Instrumentation.EndContext();
#line 10 "NestedScriptTagTagHelpers.cshtml"
            }

#line default
#line hidden

                Instrumentation.BeginContext(439, 129, true);
                WriteLiteral("            <script type=\"text/javascript\">\r\n                var tag = \'<input ch" +
"ecked=\"true\">\';\r\n            </script>\r\n        ");
                Instrumentation.EndContext();
            }
            , StartTagHelperWritingScope, EndTagHelperWritingScope);
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute("class", Html.Raw("Hello World"));
            __tagHelperExecutionContext.AddHtmlAttribute("data-delay", Html.Raw("1000"));
            __tagHelperExecutionContext.Output = await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            Instrumentation.BeginContext(139, 433, false);
            await WriteTagHelperAsync(__tagHelperExecutionContext);
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(572, 23, true);
            WriteLiteral("\r\n    </div>\r\n</script>");
            Instrumentation.EndContext();
        }
        #pragma warning restore 1998
    }
}
