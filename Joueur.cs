using System;

namespace Pendu
{
    class Joueur
    {
        private String nom;
        private int nbTrialRemain;
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int NbTrialRemain
        {
            get { return nbTrialRemain; }
            set { nbTrialRemain = value; }
        }
        public Joueur(String nom, int nbTrialRemain)
        {
            this.nom = nom;
            this.nbTrialRemain = nbTrialRemain;
        }
    }
}