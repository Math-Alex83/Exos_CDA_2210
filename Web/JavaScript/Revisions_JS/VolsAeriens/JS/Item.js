class Item{
    constructor(item){
        Object.assign(this, item);
        this.durationFormat = this.calculateDurationFormat();
    }
}