class Item{
    constructor(item){
        Object.assign(this, item);
    }

    getValues(){
        return Object.values(this);
    }

    getKeys(){
        return Object.keys(this);
    }
}

export {Item};