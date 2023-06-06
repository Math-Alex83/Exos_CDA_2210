// // JavaScript = language prototype ! le prototype est un objet en lui même. 

// const constante = ""; // La valeur doit être initialisée à la déclaration. d'où son nom...

// // Différence entre let et var
// var variable1; // a une portée de fonction
// //exemple
// function maFonction()
// {
//     if(true)
//     {
//         var toto;
//     }

//     console.log(toto);
// }
// // en dehors de la fonction, la variable var n'est plus accessible.

// let variable2; // a une portée de bloc
// // exemple2
// function maFonction2()
// {
//     if(true)
//     {
//         let toto; // en dehors de ce BLOC {} de code la variable let n'est plus accessible.
//     }

//     console.log(toto); ici la variable toto aura la valeur undefined / non défini
// }



const reponse = await fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json');
console.log(reponse);
const json = await reponse.json();
console.log(json);

const saisie = document.getElementById('zipcodeaussi');
const mesOptions = document.getElementById('mesOptions');
const monBouton = document.getElementById('monBouton');

for(let ville of json) 
{
   // console.log(ville.codePostal);

    let option = document.createElement('option');
    option.value = ville.codePostal;
    mesOptions.appendChild(option)

}

monBouton.addEventListener('click', function() {
    let valeur = saisie.value;
    console.log(valeur);

    let resultat = json.filter(ville => ville.codePostal == valeur);
    console.log(resultat);
    document.getElementById("divSuggestions").innerHTML = resultat.toString();
})
