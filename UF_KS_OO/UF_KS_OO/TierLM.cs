using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF_KS_OO
{
    internal class TierLM:Lebensmittel
    {
        public float Fettgehalt { get; set; }

        public TierLM(int brennwert, string bezeichnung, float fettgehalt):base(brennwert, bezeichnung)
        {
            Fettgehalt= fettgehalt; 
        }

        public override string ToString()
        {
            return base.ToString()+$"; Fettgehalt: ({Fettgehalt})"; 
        }
    }
}
