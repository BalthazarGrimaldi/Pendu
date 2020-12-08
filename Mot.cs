using System;

namespace Pendu
{
    class Mot
    {
        private String motATrouver;
        private char[] arrayMot;
        private char[] motTrou;
        public String MotATrouver
        {
            get { return motATrouver; }
            set { motATrouver = value; }
        }
        public char[] ArrayMot
        {
            get { return arrayMot; }
            set { arrayMot = value; }
        }
        public char[] MotTrou
        {
            get { return motTrou; }
            set { motTrou = value; }
        }
        public Mot(String motATrouver)
        {
            this.motATrouver = motATrouver;
            this.arrayMot = motATrouver.ToCharArray(0, motATrouver.Length);
            this.motTrou = genererMot(this.arrayMot);
        }
        public char[] genererMot(char[] arrayMot)
        {
            char[] motTrou = new char[arrayMot.Length];
            motTrou[0] = arrayMot[0];
            for (int i = 1; i < motTrou.Length; i++)
            {
                if (arrayMot[i] == arrayMot[0])
                {
                    motTrou[i] = arrayMot[i];
                }
                else
                {
                    motTrou[i] = '_';
                }
            }
            return motTrou;
        }
        public bool trouverLettre(char lettre)
        {
            bool rep = false;
            for (int i = 1; i < this.arrayMot.Length; i++)
            {
                if (lettre == this.arrayMot[i])
                {
                    this.motTrou[i] = lettre;
                    rep = true;
                }
            }
            return rep;
        }
        public bool isWin()
        {
            for (int i = 1; i < this.arrayMot.Length; i++)
                if (this.arrayMot[i] != this.motTrou[i])
                {
                    return false;
                }
            return true;
        }
    }
}