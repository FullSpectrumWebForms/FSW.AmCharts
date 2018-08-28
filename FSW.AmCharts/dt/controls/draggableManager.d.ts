declare var Draggable: {
    Draggable: any;
};
declare namespace controls {
    class draggableManager extends core.controlBase {
        draggable: any;
        readonly ContainerIDs: string[];
        readonly DropZoneIDs: string[];
        readonly DraggableSelector: string;
        readonly DisabledDraggable_Class: string;
        readonly OnDragStarted: boolean;
        readonly OnBeforeDragStart: boolean;
        Enabled: boolean;
        removeControl(): void;
        currentOverControl: controls.html.htmlControlBase;
        initialize(type: string, index: number, id: string, properties: {
            property: string;
            value: any;
        }[]): void;
        onDragStop(ev: any): void;
        onDragOutOtherDraggable(ev: any): void;
        onDragOverOtherDraggable(ev: any): void;
        onDragStart(ev: any): void;
        onContainerIDChangedFromServer(property: core.controlProperty<string[]>, args: {
            old: string[];
            new: string[];
        }): void;
    }
}
