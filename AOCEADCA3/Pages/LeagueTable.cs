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
            private Root Main;
            private string ErrorMessage;
            private string League = "PL";

            private async Task GetDataAsync()
            {
                try
                {
                    string uri = "https://api.football-data.org/v2/competitions/" + League + "/standings?standingType=TOTAL";
                    Main = await Http.GetJsonAsync<Root>(uri);
                    ErrorMessage = String.Empty;
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                }
            }


            protected override async Task OnInitializedAsync()
            {
                await GetDataAsync();
            }

        }
    }

