using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rallye
{
    public class Vehicule
    {
        private int numero;
        private string marque;
        private string modele;   // le pilote du véhicule
        private Pilote lePilote;

        /// <summary>
        /// constructeur 
        /// Valorise les attributs avec les valeurs passées en paramètre
        /// </summary>
        /// <param name="pUnNum">numéro du véhicule</param>
        /// <param name="pUneMarque">marque du véhicule</param>
        /// <param name="pUnModele">modèle du véhicule</param>
        public Vehicule(int pUnNum, string pUneMarque, string pUnModele)
        {
            this.numero = pUnNum;
            this.marque = pUneMarque;
            this.modele = pUnModele;
        }

        public Vehicule(int pUnNum, string pUneMarque, string pUnModele, Pilote UnPilote) : this(pUnNum, pUneMarque, pUnModele)
        {
            this.lePilote = UnPilote;
        }

        //retourne les caractéristiques du véhicule séparées par un espace
        public override string ToString()
        {
            String chaine = "Le Véhicule : " + this.numero + " Marque : " + this.marque + " Modèle " + this.modele;
            if (this.lePilote != null)
            {
                chaine += " Nom du pilote : " + this.lePilote.Nom;
            }
            return chaine;
        }

        public int Numero
        {
            get { return numero; }           
        }
        public string Modele
        {
            get { return modele; }
        }
        public string Marque
        {
            get { return marque; }            
        }
        public Pilote LePilote
        {
            get { return lePilote; }
            set { lePilote = value; }
        }
    }
}
