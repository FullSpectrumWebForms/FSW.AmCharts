using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public class CategoryFieldAttribute : Attribute
    {
    }
    public class ValueFieldAttribute : Attribute
    {
        public string ConfigId;
        public GraphType GraphType = GraphType.Line;
    }
    public class ChartData
    {
        public ChartData()
        {
        }
        public ChartData( string x, float y )
        {
            X = x;
            Y = y;
        }
        [CategoryField]
        public string X;
        [ValueField]
        public float Y;
    }
}
