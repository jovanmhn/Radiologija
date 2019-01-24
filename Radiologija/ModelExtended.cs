using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiologija
{


    public partial class operater
    {
        public string info_naziv { get { return this.ime + " " + this.prezime; } }
    }

    public partial class doktor
    {
        public string info_naziv { get { return this.titula + " " + this.ime + " " + this.prezime; } }
    }

    public partial class nalaz
    {
        public string info_datum { get { return this.datum_pregleda.ToString("dd.MM.yyyy.") + " | " + this.datum_pregleda.Hour + "h" + ":" + this.datum_pregleda.Minute + "m"; } }
    }

}
