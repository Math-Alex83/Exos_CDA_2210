

// 1) Création du lien vers le fichier Json. https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json
// fetch() est une méthode asyncrone, il nécessite donc l'opérateur await.
const reponse = await fetch('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
console.log(reponse);

// 3 méthodes de récupération de fichier, il faut savoir de quel type est le fichier. Json, Xml ou Text. ici c'est du Json.(le Json est un format Text).
const json = await reponse.json(); // converti le Json en donnée JavaScript
console.log(json);

const tabbody = document.getElementById('tabBody');

async function cards() {
    for (let card of json) {

        let tr = document.createElement('tr')

        tr.innerHTML += "<td>" + card.id + "</td>"
        tr.innerHTML += "<td>" + card.name + "</td>"
        tr.innerHTML += "<td>" + card.level + "</td>"
        tr.innerHTML += "<td>" + (card.description != undefined ? card.description : "") + "</td>"
        tr.innerHTML += "<td>" + card.power + "</td>"
        tr.innerHTML += "<td>" + card.attack + "</td>"
        tr.innerHTML += "<td>" + card.armor + "</td>"
        tr.innerHTML += "<td>" + card.damage + "</td>"
        tr.innerHTML += "<td>" + card.mitigation + "</td>"
        tr.innerHTML += "<td>" + card.played + "</td>"
        tr.innerHTML += "<td>" + card.victory + "</td>"
        tr.innerHTML += "<td>" + card.defeat + "</td>"
        tr.innerHTML += "<td>" + card.draw + "</td>"

        tabbody.appendChild(tr);
    }
}
cards();

/*
import { CollectionCartes } from "./CollectionCartes.js";
import { Carte } from "./Carte.js";

const maCollection = new CollectionCartes();
await maCollection.load().then(()=>{
    // MES INSTRUCTIONS A FAIRE UNE FOIS CHARGE
    generateBody();
});

function generateBody(){
    let tabBody= document.querySelector('#tabBody');
    maCollection.datas.forEach(d=>{
        tabbody.appendChild(generateLineWithValue(d));
    });
}


function generateLineWithValue(carte){
    let tr = document.createElement('tr');
    carte.getValues().forEach(d=>{
        let td = document.createElement('td');
        td.innerText = d;
        tr.appendChild(td);
    });
    return tr;
}
*/