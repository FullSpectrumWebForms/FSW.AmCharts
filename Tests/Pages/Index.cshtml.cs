using FSW.AmCharts;
using FSW.AmCharts.Controls;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class IndexModel : FSW.Core.FSWPage
    {

        public override void OnPageLoad()
        {
            base.OnPageLoad();

            InitializeChart1();
            InitializeChart2();

        }

        #region Chart 1

        public AmCharts<ChartData> AC_Test = new AmCharts<ChartData>();

        private void InitializeChart1()
        {
            AC_Test.Graphs[nameof(ChartData.Y)].GraphType = GraphType.Column;
            AC_Test.Graphs[nameof(ChartData.Y)].LineColor = Color.Blue;

            AC_Test.Datas.AddRange(new[]
            {
                new ChartData("1", 15),
                new ChartData("2", 30),
                new ChartData("3", 45),
                new ChartData("4", 25),
            });
        }

        #endregion

        #region Chart 2

        public AmCharts<CustomChartData> AC_Test2 = new AmCharts<CustomChartData>();

        public class CustomChartData
        {
            [CategoryField]
            public int XAxis;

            [ValueField(GraphType = GraphType.Line)]
            public float YAxisValue1;

            [ValueField(GraphType = GraphType.Line)]
            public float YAxisValue2;
        }

        private int ChartDataCounter = 1;
        private CustomChartData GenerateRandomData()
        {
            return new CustomChartData()
            {
                XAxis = ++ChartDataCounter,
                YAxisValue1 = new Random().Next(0, 1000)/10,
                YAxisValue2 = new Random().Next(0, 1000)/10,
            };
        }

        private void InitializeChart2()
        {
            AC_Test2.Graphs[nameof(CustomChartData.YAxisValue1)].FillAlpha = 0.4f;
            AC_Test2.Graphs[nameof(CustomChartData.YAxisValue2)].FillAlpha = 0.4f;


            AC_Test2.CategoryAxis.Guides = new List<GuideConfig>
            {
                new GuideConfig()
                {
                    Category = "30",
                    Label = "Dead line!",
                    Color = Color.Red,
                    LineColor = Color.Orange,
                    LineAlpha = 1,
                    Inside = true,
                    DashLength = 5,
                    LabelRotation = 90,
                    LineThickness = 3,
                }
            };

            AC_Test2.Datas.AddRange(Enumerable.Range(0, 100).Select(x => GenerateRandomData()));

            RegisterHostedService(TimeSpan.FromMilliseconds(10000), RefreshChart2);
        }
        void RefreshChart2()
        {
            using (ServerSideLock)
            {
                // warning, this will cause the chart to be refreshed twice by the client.
                // once like this shouldn't really bother, but if used a lot it will flicker the screen
                AC_Test2.Datas.Add(GenerateRandomData());
                AC_Test2.Datas.RemoveAt(0);
            }
        }
        #endregion
    }
}