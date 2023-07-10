import{Db} from "./db.js";
import { UserInterface } from "./UserInterface.js";


class FlightCollection{
    constructor(){
        this.data = [];
        this.source="./JS/flight.json";
        // valeur par défaut du sens de tri, si initialisé en true asc sinon desc
        this.sortedAsc = true;
    }
    /**
     * Chargement des données de la collection depuis le lien vers jayson
     */
    async loadDatajson(){
        this.data = await Db.getData(this.source);
        console.log(this.data);
        //Pour chaque élément de la collection, on crée une instance de vol.
        this.data = this.data.map(f => new FlightCollection(f));
    }
    /**
     * Fonction qui trie la collection par l'attribut flight_duration
     */
    sortByDuration(){

    }
}
export {FlightCollection}