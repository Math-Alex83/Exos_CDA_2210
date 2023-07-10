
class Db
{
    /**
     * Gère l'appel à une API distante
     * @param {String} _url 
     * @returns json
     */
   static async getData(_url)
   {
       let reponse = await fetch(_url);
       let json = await reponse.json();
       return json;
   }
}
export {Db}