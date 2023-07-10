import {FlightCollection} from "./flightCol.js";

// création de l'instance qui gère la collection de données
let flightCol = new FlightCollection();

// Chargement des données
 await flightCol.loadDatajson();