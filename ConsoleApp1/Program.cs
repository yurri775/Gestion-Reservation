namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionReservation gestion = new GestionReservation();
            Chambre ch1=new Chambre();
            ch1.TypeChambre=TypeChambre.SIMPLE;
            ch1.PrixNuit = 200;
            ch1.NumChambre = 1;

            Chambre ch2= new Chambre();
            ch2.TypeChambre = TypeChambre.DOUBLE;
            ch2.PrixNuit = 300;
            ch2.NumChambre = 2;

            Chambre ch3 = new Chambre();
            ch3.TypeChambre = TypeChambre.SUITE;
            ch3.PrixNuit = 350;
            ch3.NumChambre = 3;

            gestion.ajouterChambre(ch1);
            gestion.ajouterChambre(ch2);
            gestion.ajouterChambre(ch3);



            Client client = new Client();
            client.Prenom = "Ayoub";
            client.Nom = "Amrani";
            client.NumTel = "+212660237444";
            client.ajouter(new Personne( "Amrani","Omar"));

            gestion.reserver(client,new List<Chambre> { ch1, ch2 },5,DateTime.Now);


            Client client2 = new Client();
            client2.Nom = "Adlani";
            client2.Prenom = "ahmed";
            client2.NumTel = "?";
            client2.ajouter(new Personne("Adlani", "anass"));
            client2.ajouter(new Personne("????", "samia"));

            gestion.reserver(client2,new List<Chambre> { ch3 },10,new DateTime(2024, 3, 16, 10, 0, 0));

            /*            gestion.afficherChambres();
            */
            /*            gestion.reservationsAjourdhui();
            */

            Console.WriteLine(gestion.chercherReservation(client));

            Console.WriteLine("------------------------");

            gestion.afficherReservations();
            gestion.trier();
            Console.WriteLine("------------------------");
            gestion.afficherReservations();

            Console.WriteLine("-------------------------------");
            gestion.annulerReservation(client2 );
            gestion.afficherReservations();
        }
    }
}
