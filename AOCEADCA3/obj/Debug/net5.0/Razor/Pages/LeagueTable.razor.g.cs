#pragma checksum "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ba36bb885db509aeb963a0336f3b58326b11fc1"
// <auto-generated/>
#pragma warning disable 1591
namespace AOCEADCA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using AOCEADCA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\_Imports.razor"
using AOCEADCA3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LeagueTable")]
    public partial class LeagueTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
 if (Main == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Calling the API has run into a problem.</p>\r\n    ");
            __builder.AddMarkupContent(1, "<p>A reminder that the API can only make 10 requests per minute.</p>");
#nullable restore
#line 8 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mb-2 p-3");
            __builder.AddMarkupContent(4, "\r\n        Choose a country\'s domestic league you\'d like to see the results for:\r\n        ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                                                               GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                                            League

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => League = __value, League));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "selected");
            __builder.AddAttribute(12, "disabled");
            __builder.AddAttribute(13, "value", "-1");
            __builder.AddContent(14, " Choose a Football League!");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "PL");
            __builder.AddContent(18, " English Premier League");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "BL1");
            __builder.AddContent(22, " German Bundesliga");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "PD");
            __builder.AddContent(26, " Spanish La Liga");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "SA");
            __builder.AddContent(30, " Italian Serie A");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "FL1");
            __builder.AddContent(34, " French Ligue 1");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "ELC");
            __builder.AddContent(38, " Championship");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.AddMarkupContent(41, @"<thead><tr><th>Position</th>
                <th>Club</th>
                <th>Played</th>
                <th>Won</th>
                <th>Drawn</th>
                <th>Lost</th>
                <th>GF</th>
                <th>GA</th>
                <th>GD</th>
                <th>Points</th></tr></thead>
        ");
            __builder.OpenElement(42, "tbody");
#nullable restore
#line 42 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
             foreach (var standing in Main.standings)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                 foreach (var row in standing.table)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 47 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.position

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "src", 
#nullable restore
#line 49 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                                      row.team.crestUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "style", "width:2.3em; height:3em;");
            __builder.CloseElement();
            __builder.AddContent(51, " ​ ");
            __builder.AddContent(52, 
#nullable restore
#line 49 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                                                                                                   row.team.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 51 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.playedGames

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 52 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.won

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 53 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.draw

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 54 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.lost

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 55 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.goalsFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 56 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.goalsAgainst

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 57 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.goalDifference

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 58 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                             row.points

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Aaron\source\repos\AOCEADCA3\AOCEADCA3\Pages\LeagueTable.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
