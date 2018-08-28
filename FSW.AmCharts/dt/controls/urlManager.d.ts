declare namespace controls {
    class urlManager extends core.controlBase {
        initialize(type: string, index: number, id: string, properties: {
            property: string;
            value: any;
        }[]): void;
        updateUrlWithoutReloading(data: {
            url: string;
            parameters: {
                [name: string]: string;
            };
        }): void;
        redirect(url: string): void;
    }
}
