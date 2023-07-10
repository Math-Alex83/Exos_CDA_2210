class Db{
    static async fetchData(link){
        let response = await fetch(link);
        let json = await response.json();
        return json;
    }
}
  
export {Db};