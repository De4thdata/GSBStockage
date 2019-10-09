using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesStockageBO
{
    class ControleAEffectue
    {
        private int id;
        private DateTime dateControle;
        private string commentaire;

        public ControleAEffectue(int id, DateTime dateControle, string commentaire)
        {
            this.Id = id;
            this.DateControle = dateControle;
            this.Commentaire = commentaire;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateControle { get => dateControle; set => dateControle = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
    }
}
