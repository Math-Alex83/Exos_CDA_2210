class Carte{
    constructor(data){
        Object.assign(this, data);
    }

    getKeys(){
        return Object.keys(this);
    }

    getValues(){
        return Object.values(this);
    }
}

export {Carte};