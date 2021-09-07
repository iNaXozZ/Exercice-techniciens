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
        public Visite( Station uneStation, List<Borne>lesBornes)
        {
            this._etat = 'P';
            this._dureeTotale = 0;
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
        /// <summary>
        /// Montre la durée totale de la visite courante
        /// </summary>
        /// <returns>Durée totale de la visite actuelle </returns>
        public int GetDureeTotale()
        {

            this.DureeTotale = 0;
            foreach (Borne laBorne in _lesBornes)
            {
                this.DureeTotale += laBorne.GetDureeRevision();
            }
            return this.DureeTotale;
        }

        /// <summary>
        /// Montre l'état courant de la borne 
        /// </summary>
        /// <returns> L'état actuelle de la borne</returns>
        public char GetEtat()
        {

            return this._etat;
            
        }
        /// <summary>
        /// Change l'état courant de la borne
        /// </summary>
        /// <returns> de programmée à affectée / ou de affectée à réalisée </returns>
        public void ChangerEtat()
        {

            /*if (this._etat=='p')
            {
                 this._etat = 'a';   
            }
            if (this._etat=='a')
            {
                this._etat = 'r'; 
            }*/
            this._etat = (this._etat == 'P') ? 'A' : 'R';
                            //Condition      Alors  Sinon
        }
        #endregion
    }
}
