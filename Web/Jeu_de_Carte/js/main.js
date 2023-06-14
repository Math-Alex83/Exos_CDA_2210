

// 1) Création du lien vers le fichier Json. https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json
console.log('je fonctionne 1');

const reponse = await fetch('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
console.log(reponse);

const json = await reponse.json();
console.log(json);

const tabbody = document.getElementById('tabbody');

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

       /* document.getElementById("name2").innerHTML +=
            "<p>" + card.name + "</p>"
        document.getElementById("level2").innerHTML +=
            "<p>" + card.level + "</p>"
        document.getElementById("description2").innerHTML +=
            "<p>" +""+"</p>"
        document.getElementById("power2").innerHTML +=
            "<p>" + card.power + "</p>"
        document.getElementById("attack2").innerHTML +=
            "<p>" + card.attack + "</p>"
        document.getElementById("armor2").innerHTML +=
            "<p>" + card.armor + "</p>"
        document.getElementById("damage2").innerHTML +=
            "<p>" + card.damage + "</p>"
        document.getElementById("mitigation2").innerHTML +=
            "<p>" + card.mitigation + "</p>"
        document.getElementById("played2").innerHTML +=
            "<p>" + card.played + "</p>"
        document.getElementById("victory2").innerHTML +=
            "<p>" + card.victory + "</p>"
        document.getElementById("defeat2").innerHTML +=
            "<p>" + card.defeat + "</p>"
        document.getElementById("draw2").innerHTML +=
            "<p>" + card.draw + "</p>"
        */

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
    let tabbody= document.querySelector('#tabbody');
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