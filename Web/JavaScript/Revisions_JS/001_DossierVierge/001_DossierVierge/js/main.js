import {Collection} from "./Collection.js";
import {UI} from "./UI.js";
import {Event} from "./Event.js";

let subjectCollection = new Collection();
Event.collection = subjectCollection;

await subjectCollection.getCollection();

let ui = new UI(subjectCollection);
ui.generateTable();