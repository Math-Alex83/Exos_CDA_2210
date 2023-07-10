class UserInterface{
    constructor(_collection){
        this.collection = _collection;
        this.tbody = document.getElementById("tbody")
    }

    generateTable(){
        this.tbody.innerHTML = "";
        for(let item of this.collection.collection){
            let row = this.generateRow(item);
            this.tbody.appendChild(row)
        }
    }
    generateRow(item){
        let row = document.createElement("tr");
        for(let value of item.getValues()){
            let cell = this.generateCell(value);
            row.appendChild(cell);
        }
        return row;
    }
    generateCell(value){
        let cell = document.getElementById("tr");
        cell.textContent = value;
        return cell;
    }
}
export {UserInterface}