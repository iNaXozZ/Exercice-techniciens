using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_techniciens.Modèle
{
    public class TypeBorne
    {
        #region Attributs
        public static List<TypeBorne> CollClass = new List<TypeBorne>();
        private string _codeTypeBorne;
        private int _dureeRevision;
        private int _nbJourEntreRevisions;
        private int _nbUnitesEntreRevisions;

        

        #endregion


        #region Constructeur
        public TypeBorne(string codeTypeBorne,int dureeRevision,int nbJourEntreRevision,int nbUnitesEntreRevisions)
        {
            this._codeTypeBorne = codeTypeBorne;
            this._dureeRevision = dureeRevision;
            this._nbJourEntreRevisions = nbJourEntreRevision;
            this._nbUnitesEntreRevisions = nbUnitesEntreRevisions;
            TypeBorne.CollClass.Add(this);
        }
        #endregion
        #region Getters/Setters
        public string CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public int DureeRevision { get => _dureeRevision; set => _dureeRevision = value; }
        public int NbJourEntreRevisions { get => _nbJourEntreRevisions; set => _nbJourEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }
        #endregion


        #region Méthode

        #endregion
    }
}
