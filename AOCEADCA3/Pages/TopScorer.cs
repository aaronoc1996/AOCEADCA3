using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AOCEADCA3.Shared;
using Microsoft.AspNetCore.Components;

namespace AOCEADCA3.Pages
{
public partial class TopScorer : ComponentBase
    { 
    private FootballData Main;
    private string errorMessage;
    private string league = "PL";

    private async Task GetDataAsync()
    {
        try
        {
            string uri = "https://api.football-data.org/v2/competitions/" + league + "/scorers";
            Main = await Http.GetJsonAsync<FootballData>(uri);
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        await GetDataAsync();
    }

}
    }


