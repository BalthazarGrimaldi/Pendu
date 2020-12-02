using System;

namespace Pendu
{
    class Joueur
    {
        private String nom; 
        private int point;
        
        public String Nom 
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Point 
        {
            get { return point; }
            set { point = value; }
        }


        public Joueur(String nom, int point)
        {
            this.nom = nom;
            this.point = point;
        }
    }
}