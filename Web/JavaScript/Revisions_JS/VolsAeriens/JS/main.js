import {FlightCollection} from "./flightCol.js";
import { UserInterface } from "./UserInterface.js";
import { Event } from "./Event.js";

// création de l'instance qui gère la collection de données
let flightCol = new FlightCollection();

// Chargement des données
 await flightCol.loadDatajson();

 let ui = new UserInterface(subjectCollection);
 ui.generateTable();

 document.getElementById("planeRef").addEventListener("click", (e)=>{
    Event.columnSort(e);
    ui.generateTable();
 });

 document.getElementById("search").addEventListener("input", (e) => {
    Event.search(e);
    ui.generateTable();
 });