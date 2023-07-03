import { CerealsCollection } from "./CerealsCollection";

class CerealsTableTbody{
    constructor (_cerealCollection){
        this.CerealsCollection = _cerealCollection;
        this.tbody = document.getElementById("tbody");

    }
    static generateTable(){
        this.tbody.innerHTML="";

        for(let cereal of this.CerealsCollection.data){
            let trTemp = this.generateRow(cereal);
            this.tbody.appendChild();
        }
       
    }
    generateRow(cereal){
        let tr = document.createElement("tr");
        for(let val of cereal.getValue){
            let cellTemp = this.generateCell(val);
            tr.appendChild(cellTemp);
        }
        return tr;
    }

    generatCell(value){
        let td = document.createElement("td");
        td.textContent = value;
        td.classList.add("valueTableCereals");
        return td;
    }




}