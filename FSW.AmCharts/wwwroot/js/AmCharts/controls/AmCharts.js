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
                // ------------------------------------------------------------------------   CategoryAxis
                get CategoryAxis() {
                    return this.getPropertyValue("CategoryAxis");
                }
                set CategoryAxis(value) {
                    this.setPropertyValue("CategoryAxis", value);
                }
                // ------------------------------------------------------------------------   Depth3D
                get Depth3D() {
                    return this.tryGetPropertyValue("Depth3D");
                }
                set Depth3D(value) {
                    this.setPropertyValue("Depth3D", value);
                }
                // ------------------------------------------------------------------------   Angle
                get Angle() {
                    return this.tryGetPropertyValue("Angle");
                }
                set Angle(value) {
                    this.setPropertyValue("Angle", value);
                }
                // ------------------------------------------------------------------------   Legend
                get Legend() {
                    return this.tryGetPropertyValue("Legend");
                }
                set Legend(value) {
                    this.setPropertyValue("Legend", value);
                }
                // ------------------------------------------------------------------------   StartDuration
                get StartDuration() {
                    return this.tryGetPropertyValue("StartDuration");
                }
                set StartDuration(value) {
                    this.setPropertyValue("StartDuration", value);
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
                    let categoryAxis = {};
                    this.parseSubObject(this.CategoryAxis, categoryAxis);
                    if (categoryAxis.guides) {
                        for (let i = 0; i < categoryAxis.guides.length; ++i) {
                            let out = {};
                            this.parseSubObject(categoryAxis.guides[i], out);
                            categoryAxis.guides[i] = out;
                        }
                    }
                    this.chart = AmCharts.makeChart(this.element[0].id, {
                        type: this.ChartType,
                        dataProvider: [],
                        categoryField: this.CategoryField,
                        categoryAxis: categoryAxis,
                        graphs: this.graphs_,
                        chartCursor: {
                            cursorAlpha: 0
                        },
                        legend: this.Legend,
                        valueAxes: [{
                                "stackType": "regular",
                                "axisAlpha": 0.3,
                                "gridAlpha": 0
                            }],
                        depth3D: this.Depth3D,
                        angle: this.Angle,
                        startDuration: this.StartDuration,
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
                        this.parseSubObject(graph[i], this.graphs_[i]);
                    }
                }
                parseSubObject(obj, output) {
                    var keys = Object.keys(obj);
                    for (let i = 0; i < keys.length; ++i)
                        output[keys[i].substr(0, 1).toLocaleLowerCase() + keys[i].substr(1)] = obj[keys[i]];
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