﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class Borne
    {
        #region Attributs
        public static List<Borne> CollCLass = new List<Borne>();
        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;
        private TypeBorne _leType;

        #endregion


        #region Constructeur
        public Borne(int idBorne, DateTime dateDerniereRevision, int indiceCompteurUnites,TypeBorne leType)
        {
            this._idBorne = idBorne;
            this._dateDerniereRevision = dateDerniereRevision;
            this._indiceCompteurUnites = indiceCompteurUnites;
            Borne.CollCLass.Add(this);
            this._leType = leType; 
        }
        #endregion


        #region Getters/Setters
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }
        public TypeBorne LeType { get => _leType; set => _leType = value; }
        #endregion


        #region Méthode

        #endregion
    }
}
