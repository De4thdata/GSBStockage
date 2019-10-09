using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStockageBO
{
    public class ZoneStockage
    {
        private int id;
        private string nom;
        private Emplacement lEmplacement;


        public ZoneStockage(int id, string nom, Emplacement lEmplacement)
        {
            this.id = id;
            this.nom = nom;
            this.lEmplacement = lEmplacement;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        internal Emplacement LEmplacement { get => lEmplacement; set => lEmplacement = value; }
        public string Libelle { get => LEmplacement.Libelle; }
    }
}
