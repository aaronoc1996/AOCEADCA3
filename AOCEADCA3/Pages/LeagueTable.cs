using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using AOCEADCA3.Shared;

namespace AOCEADCA3.Pages
{
        public partial class LeagueTable : ComponentBase
        {
            private FootballData Main;
            private string errorMessage;
            private string league = "PL";

            private async Task GetDataAsync()
            {
                try
                {
                    string uri = "https://api.football-data.org/v2/competitions/" + league + "/standings?standingType=TOTAL";
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

