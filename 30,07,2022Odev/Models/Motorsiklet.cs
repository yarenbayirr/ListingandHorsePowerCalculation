using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_07_2022Odev
{
    public class Motorsiklet:ARAC
    {
        private double _BeygirGucu;
        public double BeygirGucu
        {
            get { return _BeygirGucu; }
            set
            {
                _BeygirGucu = value;
            }
        }

        

        public VitesTuru VitesTuru { get; set; }
        public YakitTuru YakitTuru { get; set; }
    }
   
}
