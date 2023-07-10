import { Db } from "./Db.js";
import { Item } from "./Item.js";

class Collection{
    constructor(){
        this.collection = [];
        this.source = "/json/flights.json"; // ajouter la source json
    }

    async getCollection(){
        let donnee = await Db.fetchData(this.source);
        console.log(donnee);
        this.collection = donnee;
        this.collection = this.collection.map(i=>new Item(i));
        console.log(this.collection);
    }

    // sortCollection(name, sortDirection){
    //     if(typeof(this.collection[0][name]) != "string"){
    //         this.collection.sort((a,b) => a[name] - b[name]);
    //     } else {
    //         this.collection.sort((a,b) => a[name].localeCompare(b[name]));
    //     }
    //     if(!sortDirection){
    //         this.collection.reverse();
    //     }
    // }
}

export {Collection};