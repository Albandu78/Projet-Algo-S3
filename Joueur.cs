using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Algo_S3
{
    internal class Joueur
    {
        private string nom;
        private int score;
        private List<string> motsTrouves;

        public Joueur (string nom, int score, List<string> motsTrouves)
        {
            this.nom = nom;
            this.score = score;
            this.motsTrouves = motsTrouves;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        
        public List<string> MotsTrouves
        {
            get { return motsTrouves;}
            set { motsTrouves = value;}
        }

        public bool Contain(string mot)
        {
            bool test = false;
            for(int i= 0;i<this.motsTrouves.Count;i++)
            {
                if (mot == this.motsTrouves[i])
                {
                    test = true;
                }
            }
            return test;
        }
        public void AddMot(string mot)
        {
            motsTrouves.Add(mot);
        }

        public string toString()
        {
            string j = "Le joueur "+this.nom + " possède un score de " + this.score+" et a trouvé les mots : ";
            for(int i = 0; i < this.motsTrouves.Count-1; i++)
            {
                j += motsTrouves[i]+",";
            }
            j += motsTrouves[this.motsTrouves.Count - 1];
            return j;
        }
    }
}
