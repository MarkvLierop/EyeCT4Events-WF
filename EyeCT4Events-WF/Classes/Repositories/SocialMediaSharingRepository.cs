﻿using EyeCT4Events_WF.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events_WF.Classes.Repositories
{
    public class SocialMediaSharingRepository
    {
        ISocialMediaSharing ISMS;

        public SocialMediaSharingRepository(ISocialMediaSharing ISM)
        {
            this.ISMS = ISM;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Categorie> AlleCategorienOpvragen()
        {
            return ISMS.AlleCategorienOpvragen();
        }
        public void ToevoegenCategorie(Categorie cat)
        {
            ISMS.ToevoegenCategorie(cat);
        }
        public void ToevoegenMedia(Media media)
        {
            ISMS.ToevoegenMedia(media);
        }
        public void ToevoegenLikeInMediaOfReactie(Gebruiker gebruiker, int mediaID, int reactieID)
        {
            ISMS.ToevoegenLikeInMediaOfReactie(gebruiker, mediaID, reactieID);
        }
        public void ToevoegenRapporterenMediaReactie(int mediaID, int reactieID)
        {
            ISMS.ToevoegenRapporterenMediaReactie(mediaID, reactieID);
        }
        public Media GetMediaByID(int id)
        {
            return ISMS.GetMediaByID(id);
        }
        public Categorie GetCategorieMetNaam(string naam)
        {
            return ISMS.GetCategorieMetNaam(naam);
        }
        public List<Categorie> ZoekenCategorie(string naam)
        {
            return ISMS.ZoekenCategorie(naam);
        }
        public List<Media> ZoekenMedia (string zoekterm)
        {
            return ISMS.ZoekenMedia(zoekterm);
        }
        public List<Media> AlleMediaOpvragen()
        {
            return ISMS.AlleMediaOpvragen();
        }
    }
}
