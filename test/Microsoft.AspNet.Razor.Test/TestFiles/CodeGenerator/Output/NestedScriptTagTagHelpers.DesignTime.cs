namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class NestedScriptTagTagHelpers
    {
        private static object @__o;
        private void @__RazorDesignTimeHelpers__()
        {
            #pragma warning disable 219
            string __tagHelperDirectiveSyntaxHelper = null;
            __tagHelperDirectiveSyntaxHelper = 
#line 1 "NestedScriptTagTagHelpers.cshtml"
              "something, nice"

#line default
#line hidden
            ;
            #pragma warning restore 219
        }
        #line hidden
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
#line 6 "NestedScriptTagTagHelpers.cshtml"
            

#line default
#line hidden

#line 6 "NestedScriptTagTagHelpers.cshtml"
            for(var i = 0; i < 5; i++) {

#line default
#line hidden

            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
#line 8 "NestedScriptTagTagHelpers.cshtml"
                                            __o = ViewBag.DefaultInterval;

#line default
#line hidden
            __TestNamespace_InputTagHelper.Type = "text";
            __TestNamespace_InputTagHelper2.Type = __TestNamespace_InputTagHelper.Type;
#line 8 "NestedScriptTagTagHelpers.cshtml"
                                                          __TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
#line 10 "NestedScriptTagTagHelpers.cshtml"
            }

#line default
#line hidden

            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
        }
        #pragma warning restore 1998
    }
}
