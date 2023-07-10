import { Db } from "./Db.js";
import { Item } from "./Item.js";

class Collection{
    constructor(){
        this.collection = [];
        this.collectionWork = [];
        this.source = "/json/flights.json"; // ajouter la source json
    }

    async getCollection(){
        let data = await Db.fetchData(this.source);
        console.log(data);
        this.collection = data; //  attention au data
        this.collection = this.collection.map(i=>new Item(i));
        this.collectionWork = Array.from(this.collection);
        console.log(this.collection);
    }

    sortCollection(name, sortDirection){
        if(typeof(this.collection[0][name]) != "string"){
            this.collection.sort((a,b) => a[name] - b[name]);
        } else {
            this.collection.sort((a,b) => a[name].localeCompare(b[name]));
        }
        if(!sortDirection){
            this.collection.reverse();
        }
    }

    searchCollection(value){
        let search = value.trim().toLowerCase();
        this.collection = this.collectionWork.filter(f => f.airline_name.toLowerCase().includes(search));

    }
}

export {Collection};