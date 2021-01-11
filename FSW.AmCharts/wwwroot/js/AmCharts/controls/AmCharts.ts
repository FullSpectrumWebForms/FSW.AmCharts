/// <reference path="..\..\..\..\dt\controls\html\htmlControlBase.d.ts" />

declare var AmCharts: any;

namespace controls.html.amCharts {

    enum GraphType {
        Line, Column, Step, SmoothedLine, Candlestick, Ohlc
    }
    interface GraphConfig {
        GraphType: GraphType;
        ValueField: string;
    }

    export class amCharts extends controls.html.htmlControlBase {

        // ------------------------------------------------------------------------   ChartType
        get ChartType(): string {
            return this.getPropertyValue<this, string>("ChartType").toLocaleLowerCase();
        }
        set ChartType(value: string) {
            this.setPropertyValue<this>("ChartType", value);
        }
        // ------------------------------------------------------------------------   CategoryField
        get CategoryField(): string {
            return this.getPropertyValue<this, string>("CategoryField");
        }
        set CategoryField(value: string) {
            this.setPropertyValue<this>("CategoryField", value);
        }
        // ------------------------------------------------------------------------   CategoryAxis
        get CategoryAxis(): any {
            return this.getPropertyValue<this, string>("CategoryAxis");
        }
        set CategoryAxis(value: any) {
            this.setPropertyValue<this>("CategoryAxis", value);
        }
        // ------------------------------------------------------------------------   Depth3D
        get Depth3D(): number {
            return this.tryGetPropertyValue<this, number>("Depth3D");
        }
        set Depth3D(value: number) {
            this.setPropertyValue<this>("Depth3D", value);
        }
        // ------------------------------------------------------------------------   Angle
        get Angle(): number {
            return this.tryGetPropertyValue<this, number>("Angle");
        }
        set Angle(value: number) {
            this.setPropertyValue<this>("Angle", value);
        }
        // ------------------------------------------------------------------------   Legend
        get Legend(): any {
            return this.tryGetPropertyValue<this, any>("Legend");
        }
        set Legend(value: any) {
            this.setPropertyValue<this>("Legend", value);
        }
        // ------------------------------------------------------------------------   StartDuration
        get StartDuration(): number {
            return this.tryGetPropertyValue<this, number>("StartDuration");
        }
        set StartDuration(value: number) {
            this.setPropertyValue<this>("StartDuration", value);
        }
        // ------------------------------------------------------------------------   Graphs
        graphs_: any[];
        get Graphs(): { [id: string]: GraphConfig } {
            return this.getPropertyValue<this, { [id: string]: GraphConfig }>("Graphs");
        }
        set Graphs(value: { [id: string]: GraphConfig }) {
            this.setPropertyValue<this>("Graphs", value);
        }

        get dataProvider(): any[] {
            return this.chart.dataProvider;
        }
        set dataProvider(value: any[]) {
            this.chart.dataProvider = value;
            this.chart.validateData();
        }

        checkElement: JQuery;
        label: JQuery;
        chart: any;

        initialize(type: string, index: number, id: string, properties: { property: string, value: any }[]) {
            super.initialize(type, index, id, properties);
            let that = this;

            this.parseGraphs();

            let categoryAxis: any = {};
            this.parseSubObject(this.CategoryAxis, categoryAxis);
            if (categoryAxis.guides) {
                for (let i = 0; i < categoryAxis.guides.length; ++i) {
                    let out: any = {};
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

        private parseGraphs() {
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
        private parseSubObject(obj: { [id: string]: any }, output: any) {
            var keys = Object.keys(obj);

            for (let i = 0; i < keys.length; ++i)
                output[keys[i].substr(0, 1).toLocaleLowerCase() + keys[i].substr(1)] = obj[keys[i]];
        }

        updateDataProvider(obj: any[]) {
            this.dataProvider = obj;
        }

        protected initializeHtmlElement(): void {
            this.element = $('<div></div>');
            this.appendElementToParent();
        }

    }
}
core.controlTypes['AmCharts.AmCharts'] = () => new controls.html.amCharts.amCharts();