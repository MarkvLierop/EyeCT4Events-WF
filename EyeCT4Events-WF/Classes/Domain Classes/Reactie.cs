﻿using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Persistencies;
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
        public int GeplaatstDoor { get; set; }
        public string Inhoud { get; set; }
        public int Likes { get; set; }
        public int Media { get; set; }
        public int ReactieID { get; set; }

        private Repositories.RepositoryGebruiker rg;
        public Reactie()
        {
            rg = new Repositories.RepositoryGebruiker(new MSSQLGebruiker());
        }
        public override string ToString()
        {
            return "Geplaatst Door: " + rg.GetGebruikerByID(GeplaatstDoor).ToString() + " | Reactie: " + Inhoud;
        }
    }
}
