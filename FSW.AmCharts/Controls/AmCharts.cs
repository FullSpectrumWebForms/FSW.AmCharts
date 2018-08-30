using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSW.AmCharts
{
    public enum GraphType
    {
        Line, Column, Step, SmoothedLine, Candlestick, Ohlc
    }

    public class GraphConfig
    {
        public string Id;
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GraphType GraphType;
        public string ValueField;
    }
    public enum ChartType
    {
        Serial
    }
}
namespace FSW.AmCharts.Controls
{
    public class AmCharts<DataType> : FSW.Controls.Html.HtmlControlBase
    {
        public class DataCollection : IList<DataType>
        {
            private List<DataType> Datas = new List<DataType>();
            private readonly AmCharts<DataType> Chart;

            internal DataCollection(AmCharts<DataType> amCharts)
            {
                Chart = amCharts;
            }
            public DataType this[int index]
            {
                get => Datas[index];
                set => Datas[index] = value;
            }

            public int Count => Datas.Count;

            public bool IsReadOnly => false;

            public void Add(DataType item)
            {
                Datas.Add(item);
                CallUpdate();
            }
            public void AddRange(IEnumerable<DataType> items)
            {
                Datas.AddRange(items);
                CallUpdate();
            }
            private void CallUpdate()
            {
                Chart.CallCustomClientEvent("updateDataProvider", Datas);
            }
            public void Clear()
            {
                Datas.Clear();
                CallUpdate();
            }

            public bool Contains(DataType item)
            {
                return Datas.Contains(item);
            }

            public void CopyTo(DataType[] array, int arrayIndex)
            {
                Datas.CopyTo(array, arrayIndex);
            }

            public IEnumerator<DataType> GetEnumerator()
            {
                return Datas.GetEnumerator();
            }

            public int IndexOf(DataType item)
            {
                return Datas.IndexOf(item);
            }

            public void Insert(int index, DataType item)
            {
                Datas.Insert(index, item);
                CallUpdate();
            }

            public bool Remove(DataType item)
            {
                var res = Datas.Remove(item);
                if (res)
                    CallUpdate();
                return res;
            }

            public void RemoveAt(int index)
            {
                Datas.RemoveAt(index);
                CallUpdate();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)Datas).GetEnumerator();
            }
        }


        public override string ControlType => "AmCharts.AmCharts";


        public string CategoryField
        {
            get => GetProperty<string>(PropertyName());
            set => SetProperty(PropertyName(), value);
        }
        public ChartType ChartType
        {
            get => (ChartType)Enum.Parse(typeof(ChartType), GetProperty<ChartType>(PropertyName()).ToString(), true);
            set => SetProperty(PropertyName(), value.ToString());
        }

        public DataCollection Datas;
        public Utility.ControlPropertyDictionary<GraphConfig> Graphs;
        public override void InitializeProperties()
        {
            base.InitializeProperties();

            Graphs = new Utility.ControlPropertyDictionary<GraphConfig>(this, nameof(Graphs));
            Datas = new DataCollection(this);
            CategoryField = "";
            ChartType = ChartType.Serial;

            InitializeGraphsAndCategoryField();
        }


        private void InitializeGraphsAndCategoryField()
        {
            foreach (var field in typeof(DataType).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                var attributes = (CategoryFieldAttribute[])field.GetCustomAttributes(typeof(CategoryFieldAttribute), true);
                if (attributes?.Length == 1)
                    CategoryField = field.Name;
                var valueFieldAttributes = (ValueFieldAttribute[])field.GetCustomAttributes(typeof(ValueFieldAttribute), true);
                if (valueFieldAttributes?.Length == 1)
                {
                    var attribute = valueFieldAttributes[0];

                    var graph = new GraphConfig
                    {
                        Id = attribute.ConfigId ?? field.Name,
                        GraphType = attribute.GraphType,
                        ValueField = field.Name
                    };

                    Graphs.Add(graph.Id, graph);
                }
            }
        }
    }
}
