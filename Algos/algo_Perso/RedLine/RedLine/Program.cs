using RedLine.Cartes;

PaquetReponse pr = new();
PaquetQuestion pq = new();
CarteQuestion cq = new("Question");
CarteReponse cr = new("Reponse");

Console.WriteLine(cr.PlacerDans(pq) ? "CR à été ajouté dans PQ" : "CR n'a pas pu etre ajouter dans PQ");
Console.WriteLine(cr.PlacerDans(pr) ? "CR à été ajouté dans PR" : "CR n'a pas pu etre ajouter dans PR");
Console.WriteLine(cq.PlacerDans(pq) ? "CQ à été ajouté dans PQ" : "CQ n'a pas pu etre ajouter dans PQ");
Console.WriteLine(cq.PlacerDans(pr) ? "CQ à été ajouté dans PR" : "CQ n'a pas pu etre ajouter dans PR");

