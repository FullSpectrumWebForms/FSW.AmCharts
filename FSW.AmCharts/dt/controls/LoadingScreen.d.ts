declare namespace controls {
    class loadingScreen extends core.controlBase {
        element: JQuery;
        loader: JQuery;
        initialize(type: string, index: number, id: string, properties: {
            property: string;
            value: any;
        }[]): void;
        showLoadingScreen(message: any): void;
        hideLoadingScreen(): void;
    }
}
