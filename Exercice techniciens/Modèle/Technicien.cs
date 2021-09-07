using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class Technicien
    {
        #region Attributs
        public static List<Technicien> CollCLass = new List<Technicien>();
        private int _matricule;
        private string _nom;
        private string _prenom;
        private List<Visite> _lesVisites;

        #endregion


        #region Constructeur
        public Technicien ( int matricule, string nom, string prenom)
        {
            this._matricule = matricule;
            this._nom = nom;
            this._prenom = prenom;
            this._lesVisites = new List<Visite>();
            Technicien.CollCLass.Add(this);
        }
        #endregion


        #region Getters/Setters
        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion


        #region Méthode
        public int getTempsOccupe()
        {
            int result = 0;
            foreach(Visite laVisite in this._lesVisites)
            {
                result += laVisite.GetDureeTotale();
            }
            return result;
        }

        public void affecterVisite(Visite uneVisite)
        {
            uneVisite.ChangerEtat();
            this._lesVisites.Add(uneVisite);
        }

        public List<Visite>getLesVisites()
        {

        }
        #endregion
    }
}
