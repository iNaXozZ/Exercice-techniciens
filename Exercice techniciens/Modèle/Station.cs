using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class Station
    {
        #region Attributs
        public static List<Station> CollClass = new List<Station>();
        private int _idStation;
        private string _libelleEmplacement;
        private List<Borne> _LesBornes;
        #endregion


        #region Constructeur
        public Station(int idStation,string libelleEmplacement)
        {
            this._idStation = idStation;
            this._libelleEmplacement = libelleEmplacement;
            Station.CollClass.Add(this);
            this._LesBornes = new List<Borne>();
        }

       
        #endregion


        #region Getters/Setters
        public int IdStation { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => _LesBornes; set => _LesBornes = value; }
        #endregion


        #region Méthode
        public int GetID()
        {
            
            return;
        }
        public int GetLibelleEmplacement()
        {
            return; 
        }
        public List<Visite>GetVisiteAFaire()
        {
            return
        }
        #endregion
    }
}
