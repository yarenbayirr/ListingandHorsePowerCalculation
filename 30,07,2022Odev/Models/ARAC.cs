using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _30_07_2022Odev
{
    public class ARAC
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        private DateTime _Datetime;
        public DateTime UretimTarihi 
        { 
          get { return _Datetime; }
          set 
            { _Datetime = DateTime.Now; }
        }
        public bool SelesiVarMi { get; set; }
        public bool VitesiVarMi { get; set; }
        public Color Renk { get; set; }
        public string KoltukSayisi { get; set; }

        





    }
}
