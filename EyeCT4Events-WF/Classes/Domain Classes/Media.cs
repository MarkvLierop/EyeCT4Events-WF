﻿using EyeCT4Events_WF.Classes.Persistencies;
using EyeCT4Events_WF.Exceptions;
using EyeCT4Events_WF.Persistencies;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes
{
    public class Media
    {
        public int Categorie { get; set; }
        public int Flagged { get; set; }
        public int GeplaatstDoor { get; set; }
        public int Likes { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
        public string Pad { get; set; }
        public string Beschrijving { get; set; }

        Repositories.RepositorySocialMediaSharing smsr;
        Repositories.RepositoryGebruiker rg;
        public Media()
        {
            smsr = new Repositories.RepositorySocialMediaSharing(new MSSQLSMS());
            rg = new Repositories.RepositoryGebruiker(new MSSQLGebruiker());
        }
        public string FilterVastStellen()
        {
            if (Type == "Afbeelding")
            {
                return "Afbeelding|*"+GetBestandsExtentie();
            }
            else if (Type == "Audio")
            {
                return "Audio Bestand|*" + GetBestandsExtentie();
            }
            else if (Type == "Video")
            {
                return "Video Bestand|*" + GetBestandsExtentie();
            }
            return "Overige Bestanden|*" + GetBestandsExtentie();
        }
        int hoogsteID;
        public void BestandOpslaan(string safeFileName, string fileName)
        {
            try
            {

                if (smsr.SelectHoogsteMediaID().ID == 1)
                {
                    hoogsteID = 1;
                }
                else
                {
                    hoogsteID = smsr.SelectHoogsteMediaID().ID+1;
                }
                string directory = "SocialMediaSharingData\\" + hoogsteID.ToString() + "\\";
                Pad = directory + safeFileName;
                Directory.CreateDirectory(directory);
                File.Copy(fileName, directory + safeFileName);
            }
            catch (Exception e)
            {
                throw new FoutBijOpslaanBestandException(e.Message);
            }
        }
        public override string ToString()
        {
            return "Geplaatst Door: "+rg.GetGebruikerByID(GeplaatstDoor).ToString() + " | Aantal keren gerapporteerd: " + Flagged.ToString();
        }
        public string GeplaatstDoorGebruiker()
        {
            return rg.GetGebruikerByID(GeplaatstDoor).ToString();
        }
        public string GetBestandsNaam()
        {
            string[] bestandsnaam = Pad.Split('\\');
            string test = bestandsnaam[bestandsnaam.Count() - 1];
            return bestandsnaam[bestandsnaam.Count() -1];
        }
        private string GetBestandsExtentie()
        {
            string[] splitPad = Pad.Split('.');
            return "."+splitPad[splitPad.Count()-1];
        }
    }
}
