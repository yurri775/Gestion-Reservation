using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Client
    {
        string nom, prenom, numTel;
        List<Personne> Personnes;

        public Client()
        {
            nom = prenom = numTel = "";
            Personnes = new List<Personne>();
        }

        public override string? ToString()
        {
            return "Cliennt Nom: " + nom + " prenom " + prenom + " numtel " + numTel;
        }

        public void ajouter(Personne person)
        {
            Personnes.Add(person);
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        internal List<Personne> Personnes1 { get => Personnes; set => Personnes = value; }
    }
}
