using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class Visite
    {
        #region Attributs
        public static List<Visite> Collclass = new List<Visite>();
        private char _etat;
        private int _dureeTotale;
        private Station _laStation;
        private List<Borne> _lesBornes;

        #endregion


        #region Constructeur
        public Visite( int dureeTotale, Station uneStation, List<Borne>lesBornes)
        {
            this._etat = 'P';
            this._dureeTotale = dureeTotale;
            this._lesBornes = lesBornes;
            this._laStation = uneStation;
            Visite.Collclass.Add(this);
        }
        #endregion


        #region Getters/Setters
        public char Etat { get => _etat; set => _etat = value; }
        public int DureeTotale { get => _dureeTotale; set => _dureeTotale = value; }
        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }
        #endregion


        #region Méthode

        public int GetDureeTotale()
        {
            int result = 0;
            result = this.DureeTotale;
            return result;
        }
        public char GetEtat()
        {
            char result = this._etat;
            return result;
        }
        public void ChangerEtat()
        {
            
            if (this._etat=='p')
            {
                 this._etat = 'a';   
            }
            if (this._etat=='a')
            {
                this._etat = 'r'; 
            }

        }
        #endregion
    }
}
