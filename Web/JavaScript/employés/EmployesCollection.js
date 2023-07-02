import { Employe } from "./Employe.js";

class EmployesCollection{
    constructor(){
        this.datasource= "https://arfp.github.io/tp/web/frontend/employees/employees.json";
        this.datas=[];
    }

    async load(){
        let repDatas = await fetch(this.datasource);
        let json = await repDatas.json();
        for (let d of json.data){
            this.datas.push(new Employe(d));
        }
        console.log(this.datas);
    }
    duplicateEmploye(id){
        let employee= this.datas.find(e=>e.id===id)
        if(employee != undefined){
           return id=this.lookForHigherId + 1;

        }
    }

    lookForHigherId(){
        let copyOfId = this.getOnlyIDList();
        return copyOfId.sort((a,b)=>a-b);// ON TRIE LES ELEMENTS AVEC LEURS ID ET ON RECUPERE L'ELEMENT AVEC LA VALEUR LA PLUS HAUTE
    }

    getOnlyIDList(){
        return this.getOnlyDataList('id');
    }

    getOnlyDataList(data){
        let coll = [];
        this.datas.forEach(d => coll.push(d[data]));
        return coll;
    }
}

export { EmployesCollection };