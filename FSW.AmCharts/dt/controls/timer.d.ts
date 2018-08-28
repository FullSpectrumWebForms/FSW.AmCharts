declare namespace controls {
    class Timer extends core.controlBase {
        Interval: number;
        Enabled: boolean;
        OnlyOnce: boolean;
        removeControl(): void;
        timer: any;
        initialize(type: string, index: number, id: string, properties: {
            property: string;
            value: any;
        }[]): void;
        resetTimer(): void;
        onTick(): void;
        onIntervalChangedFromServer(property: core.controlProperty<number>, args: {
            old: number;
            new: number;
        }): void;
    }
}
