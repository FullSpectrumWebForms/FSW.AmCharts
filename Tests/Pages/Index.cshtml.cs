using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSW.AmCharts;
using FSW.AmCharts.Controls;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tests.Pages
{
    public class IndexModel : FSW.Core.FSWPage
    {
        public AmCharts<ChartData> AC_Test = new AmCharts<ChartData>();
        public override void OnPageLoad()
        {
            base.OnPageLoad();

            AC_Test.Graphs[nameof(ChartData.Y)].GraphType = GraphType.Column;

            AC_Test.Datas.AddRange(new[]
            {
                new ChartData("test 1", 15),
                new ChartData("test 2", 30),
                new ChartData("test 3", 45),
                new ChartData("test 4", 25),
            });
        }
    }
}