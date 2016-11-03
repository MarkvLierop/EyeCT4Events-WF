using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Reactie
    {
        public DateTime DatumTijd { get; set; }
        public int Flagged { get; set; }
        public string GeplaatstDoor { get; set; }
        public string Inhoud { get; set; }
        public int Likes { get; set; }
        public int Media { get; set; }
        public int ReactieID { get; set; }

        public Reactie()
        {

        }
    }
}
