// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Advanced.Blazor.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\_Imports.razor"
using Advanced.Models;

#line default
#line hidden
#nullable disable
    public partial class CustomSelect<TValue> : InputBase<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "d:\git\pro-asp.net-core-3\37 - Blazor WebAssembly\End of Chapter\Advanced\Blazor\Forms\CustomSelect.razor"
       

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public IDictionary<string, TValue> Values { get; set; }

    [Parameter]
    public Func<string, TValue> Parser { get; set; }

    protected override bool TryParseValueFromString(string value, out TValue result,
            out string validationErrorMessage) {
        try {
            result = Parser(value);
            validationErrorMessage = null;
            return true;
        } catch {
            result = default(TValue);
            validationErrorMessage = "The value is not valid";
            return false;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
