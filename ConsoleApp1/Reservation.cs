using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reservation
    {
        static int cp = 0;
        int numReservation;
        Client client;
        List<Chambre> chambreList;
        DateTime dateEntree;
        int nbJours;
        float montant;

        public Reservation()
        {
            cp++;
            numReservation = cp;
            nbJours = 0;
            chambreList = new List<Chambre>();
            dateEntree = DateTime.Now;
            montant = 0;
        }

        public override string? ToString()
        {
            string s = "";
            foreach (var item in chambreList)
            {
                s += " " + item.ToString();
            }
            s += " "  +client.ToString()+ " daateEntree " + dateEntree.ToString() + " nb jours " + nbJours + " montant : " + montant;
            return s;
        }

        public void  AjouterChambre(Chambre chambre)
        {
            if(chambreList.Contains(chambre) == false)
            {
                chambreList.Add(chambre);
                montant += chambre.PrixNuit * nbJours;
                chambre.Disponibilite = false;

            }
        }

        public int NumReservation { get => numReservation;  }
        public DateTime DateEntree { get => dateEntree; set => dateEntree = value; }
        public int NbJours { get => nbJours; set => nbJours = value; }
        public float Montant { get => montant; set => montant = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Chambre> ChambreList { get => chambreList; set => chambreList = value; }
    }
}
