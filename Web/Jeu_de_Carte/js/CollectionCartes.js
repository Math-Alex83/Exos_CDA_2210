
/*
import {Carte} from './Carte.js';

class CollectionCartes
{
    constructor()
    {
        this.datasource = 'https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json';
        this.datas = [];
    }
    async load()
    {
        try
        {
            let response = await fetch('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');            
            let dataFromJson = await response.json();
            dataFromJson.forEach(d=> this.datas.push(new Carte(d)));
        } catch (error){

        }
    }   
}
export {CollectionCartes};
*/