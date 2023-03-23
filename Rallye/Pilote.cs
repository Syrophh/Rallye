using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rallye
{
    public class Pilote
    {
        private int numero;
        private string nom;
        private int cumulTemps;
        private int nbPoints;

        // le constructeur
        /// <summary>
        /// Initialise une nouvelle instance de la classe Pilote 
        ///  et met à zéro le nombre de points et le cumul de temps
        /// </summary>
        /// <param name="unNumero">Le numero</param>
        /// <param name="unNom">Le nom</param>        
        public Pilote(int unNumero, string unNom)
        {
            this.numero = unNumero;
            this.nom = unNom;
            this.cumulTemps = 0;
            this.nbPoints = 0;
        }
        public string Nom
        {
            get { return nom; }
        }

        // les méthodes

        /// <summary>
        /// cumule le temps passé en paramètre à l'attribut cumulTemps
        /// et met à jour le nombre de points (voir sujet)
        /// </summary>
        /// <param name="unTemps"></param>

        public void AjouteTemps(int unTemps)
        {
            this.cumulTemps += unTemps;
            if (unTemps < 600)
                this.nbPoints += 10;
            else
                if (unTemps < 800)
                    this.nbPoints -= 3;
                else
                    this.nbPoints -= 5; 
        }

        public string ToString()
        {
            return "Identité du pilote : " + this.numero.ToString() + " " + this.nom + " \n";
        }
        
        public int GetNumero()
        {
            return numero;
        }

        public int CumulTemps
        {
            get { return cumulTemps; }
        }

        public int NbPoints
        {
            get { return nbPoints; }
        }

    }
}
