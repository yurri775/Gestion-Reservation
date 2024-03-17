using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GestionReservation
    {
        List<Reservation> reservations;
        List<Chambre> chambres;

        public GestionReservation()
        {
            reservations = new List<Reservation>();
            chambres = new List<Chambre>(); 
        }

        internal List<Reservation> Reservations { get => reservations; set => reservations = value; }
        internal List<Chambre> Chambres { get => chambres; set => chambres = value; }

        public void ajouterChambre(Chambre chambre)
        {
            if (chambres.Contains(chambre) == false)
            {
                chambres.Add(chambre);
            }
        }
        public void afficherChambres()
        {
            foreach (var item in chambres)
            {
                Console.WriteLine(item);
            }
        }

        public bool reserver(Client client,List<Chambre> chambres,int nbJour,DateTime dateEntree)
        {
            foreach (var item in chambres)
            {
                if (item.Disponibilite == false)
                {
                    return false;
                }
            }
            Reservation reservation=new Reservation();
            reservation.NbJours = nbJour;
            reservation.DateEntree = dateEntree;
            reservation.Client = client;
            foreach (var item in chambres)
            {
                reservation.AjouterChambre(item);
            }
            Console.WriteLine(client);
            reservations.Add(reservation);

            return true;

        }
        public Reservation chercherReservation(Client client)
        {
            foreach (var item in reservations)
            {
                if (item.Client.Equals(client)) 
                {
                    return item;
                }
            }
            return null;
        }

        public bool annulerReservation(Client client)
        {
            Reservation reservation=chercherReservation(client); 
            if (reservation == null)
            {
                return false;
            }
            foreach (var item in reservation.ChambreList)
            {
                item.Disponibilite=true;   
            }
            reservations.Remove(reservation);
            return true;
        }

        public void reservationsAjourdhui()
        {
            foreach (var item in reservations)
            {
                if (DateTime.Compare(item.DateEntree.Date,DateTime.Today) == 0)
                {
                 Console.WriteLine(item);
                }
            }
        }
        public void afficherReservations()
        {
            foreach (var item in reservations)
            {
                Console.WriteLine(item);

            }
        }

        public void trier()
        {
            for (int i = 0; i < reservations.Count - 1; i++)
            {
                for (int j = 0; j < reservations.Count - i - 1; j++)
                {
                    if (reservations[j].DateEntree > reservations[j + 1].DateEntree)
                    {
                        Reservation temp = reservations[j];
                        reservations[j] = reservations[j + 1];
                        reservations[j + 1] = temp;
                    }
                }
            }
        }
    }


}
