

// 1) Création du lien vers le fichier Json. https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json
console.log('je fonctionne 1');

const reponse = await fetch('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
console.log(reponse);

const json = await reponse.json();
console.log(json);

async function cards() {
    for (let card of json) {

        document.getElementById("id").innerHTML +=
            "<p>" + card.id + "</p>"
        document.getElementById("name").innerHTML +=
            "<p>" + card.name + "</p>"
        document.getElementById("level").innerHTML +=
            "<p>" + card.level + "</p>"
        document.getElementById("description").innerHTML +=
            "<p>" +"0"+"</p>"
        document.getElementById("power").innerHTML +=
            "<p>" + card.power + "</p>"
        document.getElementById("attack").innerHTML +=
            "<p>" + card.attack + "</p>"
        document.getElementById("armor").innerHTML +=
            "<p>" + card.armor + "</p>"
        document.getElementById("damage").innerHTML +=
            "<p>" + card.damage + "</p>"
        document.getElementById("mitigation").innerHTML +=
            "<p>" + card.mitigation + "</p>"
        document.getElementById("played").innerHTML +=
            "<p>" + card.played + "</p>"
        document.getElementById("victory").innerHTML +=
            "<p>" + card.victory + "</p>"
        document.getElementById("defeat").innerHTML +=
            "<p>" + card.defeat + "</p>"
        document.getElementById("draw").innerHTML +=
            "<p>" + card.draw + "</p>"
    }
}
cards();
