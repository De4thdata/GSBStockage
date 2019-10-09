using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockage
{
    class ControleAEffectueManager
    {
        private static ControleAEffectueManager uneInstance;
        public static ControleAEffectueManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ControleAEffectueManager();
            }
            return uneInstance;
        }
    }
}
