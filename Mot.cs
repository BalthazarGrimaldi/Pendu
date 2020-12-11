using System;

namespace Pendu
{
    class Mot
    {
        private String motATrouver;
        private char[] arrayMot;
        private char[] motTrou;
        private int nbMotTrou;
        private char lettre;
        private char[] lettres;
        private int numeroLettre;
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
        public int NbMotTrou
        {
            get { return nbMotTrou; }
            set { nbMotTrou = value; }
        }
        public char Lettre
        {
            get { return lettre; }
            set { lettre = value; }
        }
        public char[] Lettres
        {
            get { return lettres; }
            set { lettres = value; }
        }
        public Mot(String motATrouver)
        {
            motATrouver = motATrouver.ToUpper();
            this.motATrouver = motATrouver;
            this.nbMotTrou = 0;
            this.numeroLettre = 0;
            this.arrayMot = motATrouver.ToCharArray(0, motATrouver.Length);
            this.Lettres = new char[26];
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
                    motTrou[i] = '-';
                    this.nbMotTrou++;
                }
            }
            return motTrou;
        }
        public bool trouverLettre(char lettrePost)
        {
            bool rep = false;
            bool rep2 = true;
            this.lettre = lettrePost;
            for (int i = 1; i < this.arrayMot.Length; i++)
            {
                if (lettrePost == this.arrayMot[i])
                {
                    rep = true;
                    if (this.arrayMot[i] != this.motTrou[i])
                    {
                        this.motTrou[i] = lettrePost;
                        this.nbMotTrou--;
                    }
                }
            }
            if (!rep)
            {
                for (int x = 0; x < this.lettres.Length; x++)
                {
                    if (this.lettres[x] == lettrePost)
                    {
                        rep2 = false;
                    }
                }
                if (rep2)
                {
                    this.lettres[this.numeroLettre] = lettrePost;
                    this.numeroLettre++;
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