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

            this.chart = AmCharts.makeChart(this.element[0].id, {
                type: this.ChartType,
                dataProvider: [{
                    X: "salut", Y: 15
                }],
                categoryField: this.CategoryField,
                graphs: this.graphs_
            });

        }

        private parseGraphs() {
            this.graphs_ = [];
            let graph = Object.keys(this.Graphs).map(x => this.Graphs[x]);
            for (let i = 0; i < graph.length; ++i) {
                var type = (graph[i].GraphType).toString();
                type = type.substr(0, 1).toLocaleLowerCase() + type.substr(1);
                this.graphs_[i] = {
                    type: type,
                    valueField: graph[i].ValueField
                };
            }
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