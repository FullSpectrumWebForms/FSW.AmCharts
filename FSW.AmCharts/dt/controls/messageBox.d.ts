declare namespace controls {
    class messageBox extends core.controlBase {
        mBox: any;
        initialize(type: string, index: number, id: string, properties: {
            property: string;
            value: any;
        }[]): void;
        showMessageBox(parameters: {
            title: string;
            text: string;
            type: string;
        }): void;
    }
}
