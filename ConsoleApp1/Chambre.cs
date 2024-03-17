using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chambre
    {
        int numChambre;
        TypeChambre typeChambre;
        float prixNuit;
        bool disponibilite=true;

        public Chambre()
        {
            this.numChambre = 0;
          
            this.prixNuit  =0;
        }

        public override string? ToString()
        {
            return "num " + numChambre + " prix " + prixNuit + " type " + typeChambre.ToString();
        }

        public int NumChambre { get => numChambre; set => numChambre = value; }
        public float PrixNuit { get => prixNuit; set => prixNuit = value; }
        internal TypeChambre TypeChambre { get => typeChambre; set => typeChambre = value; }
        public bool Disponibilite { get => disponibilite; set => disponibilite = value; }
    }
}
