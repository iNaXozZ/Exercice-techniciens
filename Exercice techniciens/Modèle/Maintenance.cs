using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class Maintenance
    {

        #region Attributs
        public static List<Maintenance> Collclass = new List<Maintenance>();
        private List<Station> _lesStations;
        private List<Technicien> _lesTechniciens;
        private List<Visite> _lesVisites;

       
        #endregion


        #region Constructeur
        public Maintenance(List<Technicien>lesTechniciens, List<Station> lesStations)
        {
            Maintenance.Collclass.Add(this);
            this._lesStations = lesStations;
            this._lesTechniciens = lesTechniciens ;
            this._lesVisites = new List<Visite>();
        }
        #endregion


        #region Getters/Setters
        public List<Station> LesStations { get => _lesStations; set => _lesStations = value; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion


        #region Méthode

        #endregion
    }
}
