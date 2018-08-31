/// <reference path="..\..\..\..\dt\controls\html\htmlControlBase.d.ts" />
var controls;
(function (controls) {
    var html;
    (function (html) {
        var amCharts;
        (function (amCharts_1) {
            let GraphType;
            (function (GraphType) {
                GraphType[GraphType["Line"] = 0] = "Line";
                GraphType[GraphType["Column"] = 1] = "Column";
                GraphType[GraphType["Step"] = 2] = "Step";
                GraphType[GraphType["SmoothedLine"] = 3] = "SmoothedLine";
                GraphType[GraphType["Candlestick"] = 4] = "Candlestick";
                GraphType[GraphType["Ohlc"] = 5] = "Ohlc";
            })(GraphType || (GraphType = {}));
            class amCharts extends controls.html.htmlControlBase {
                // ------------------------------------------------------------------------   ChartType
                get ChartType() {
                    return this.getPropertyValue("ChartType").toLocaleLowerCase();
                }
                set ChartType(value) {
                    this.setPropertyValue("ChartType", value);
                }
                // ------------------------------------------------------------------------   CategoryField
                get CategoryField() {
                    return this.getPropertyValue("CategoryField");
                }
                set CategoryField(value) {
                    this.setPropertyValue("CategoryField", value);
                }
                get Graphs() {
                    return this.getPropertyValue("Graphs");
                }
                set Graphs(value) {
                    this.setPropertyValue("Graphs", value);
                }
                get dataProvider() {
                    return this.chart.dataProvider;
                }
                set dataProvider(value) {
                    this.chart.dataProvider = value;
                    this.chart.validateData();
                }
                initialize(type, index, id, properties) {
                    super.initialize(type, index, id, properties);
                    let that = this;
                    this.parseGraphs();
                    this.chart = AmCharts.makeChart(this.element[0].id, {
                        type: this.ChartType,
                        dataProvider: [],
                        categoryField: this.CategoryField,
                        graphs: this.graphs_
                    });
                }
                parseGraphs() {
                    this.graphs_ = [];
                    let graph = Object.keys(this.Graphs).map(x => this.Graphs[x]);
                    for (let i = 0; i < graph.length; ++i) {
                        var type = (graph[i].GraphType).toString();
                        type = type.substr(0, 1).toLocaleLowerCase() + type.substr(1);
                        delete graph[i].GraphType;
                        this.graphs_[i] = {
                            type: type,
                        };
                        var keys = Object.keys(graph[i]);
                        for (let j = 0; j < keys.length; ++j)
                            this.graphs_[i][keys[j].substr(0, 1).toLocaleLowerCase() + keys[j].substr(1)] = graph[i][keys[j]];
                    }
                }
                updateDataProvider(obj) {
                    this.dataProvider = obj;
                }
                initializeHtmlElement() {
                    this.element = $('<div></div>');
                    this.appendElementToParent();
                }
            }
            amCharts_1.amCharts = amCharts;
        })(amCharts = html.amCharts || (html.amCharts = {}));
    })(html = controls.html || (controls.html = {}));
})(controls || (controls = {}));
core.controlTypes['AmCharts.AmCharts'] = () => new controls.html.amCharts.amCharts();
//# sourceMappingURL=AmCharts.js.map