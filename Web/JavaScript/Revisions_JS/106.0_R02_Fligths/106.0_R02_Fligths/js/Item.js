class Item{
    constructor(item){
        Object.assign(this, item);
        this.durationFormat = this.calculateDurationFormat();
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }

    calculateDurationFormat(){
        let hours = Math.floor(this.flight_duration / 60);
        let minutes = this.flight_duration%60
        return `${hours}:${minutes}:00`
    }
}

export {Item};