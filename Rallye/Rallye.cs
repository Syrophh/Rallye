using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rallye
{
public class Rallye
{
        private string nom;
        private int capacitéVéhicules;   // capacité d'accueil du rallye en nb de véhicules 
        private List<Vehicule> lesVehicules;  //collection véhicules inscrits au rallye

        //constructeur
        public Rallye(string pnom, int pcapacité)
        {
            this.nom = pnom;
            this.capacitéVéhicules = pcapacité;
            this.lesVehicules = new List<Vehicule>();

        }

        public string Nom
        {
            get { return nom; }
        }
        public int CapacitéVéhicules
        {
            get { return capacitéVéhicules; }
        }
        public List<Vehicule> LesVehicules
        {
            get { return lesVehicules; }
        }

        /// <summary>
        /// Cette méthode ajoute un véhicule à la collection lesVehicules.
        /// Lea attributs du véhicule à ajouter sont passés en paramètre . 
        /// Aucun contrôle n'est effectué lors de l'ajout.
        /// </summary>
        /// <param name="pnumero">numéro du véhicule</param>
        /// <param name="pMarque">marque du véhicule</param>
        /// <param name="pModele">modèle du véhicule</param>
        /// <param name="unPilote">pilote du véhicule pour le rallye</param>
        public void AjouterVehicule(int pnumero, string pMarque, string pModele, Pilote unPilote)
        {
            Vehicule unVehicule = new Vehicule(pnumero, pMarque, pModele);
            // on renseigne le pilote du véhicule :lePilote
            unVehicule.LePilote = unPilote;
            // on ajoute l'objet unVehicule à la collection les Vehicules
            lesVehicules.Add(unVehicule);

        }
        /// <summary>
        /// Cette méthode ajoute un véhicule à la collection lesVehicules.
        /// Lea attributs du véhicule à ajouter sont passés en paramètre . 
        /// Aucun contrôle n'est effectué lors de l'ajout.
        /// </summary>
        /// <param name="pnumero">numéro du véhicule</param>
        /// <param name="pMarque">marque du véhicule</param>
        /// <param name="pModele">modèle du véhicule</param>    
        public void AjouterVehicule(int pnumero, string pMarque, string pModele)
        {
            Vehicule unVehicule = new Vehicule(pnumero, pMarque, pModele);            
            // on ajoute l'objet unVehicule à la collection les Vehicules
            lesVehicules.Add(unVehicule);

        }

        public void AjouterVehicule(List<Vehicule> vehicules)
        {
            // TODO
        }

        /// <summary>
        /// Vérifie que le véhicule dont l'immatriculation est passée en paramètres
        /// est bien inscrit au rallye
        /// </summary>
        /// <param name="pnumero">immatriculation cherchée</param>
        /// <returns>true si le véhicule est inscrit au rallye</returns>
        public bool VehiculeInscrit(int pnumero)
        {
            int i = 0;
            while (i < this.lesVehicules.Count && this.lesVehicules[i].Numero != pnumero)
            {
                i++;
            }
            if (this.lesVehicules[i].Numero == pnumero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// supprime le véhicule ayant le numéro pnuméro de la collection lesVéhicules
        /// Si le véhicule n'est pas dans la collection (Pas de véhicule ayant pour numéro pnumero),
        /// une exception est levée
        /// </summary>
        /// <param name="pnumero">numéro du véhicule à supprimer </param>
        /// <returns></returns>
        public void SupprimerVéhicule(int pnumero)
        {
           
        }

        /// <summary>
        /// retourne une chaine de caractères composée des caractéristiques des 
        /// véhicules participants au rallye séparés par un espace
        /// </summary>
        /// <returns>chaine comportant les la liste des véhicules</returns>
        public string ListerLesVéhicules()
        {
            return null;

        }

        /// <summary>
        /// Retourne le nombre de voitures inscrites au rallye
        /// </summary>
        /// <returns></returns>
        public int RetournerNbVéhicules()
        {
            return this.lesVehicules.Count;
        }

        /// <summary>
        /// Retourne la position du véhicule dont le numéro est passé en paramètre
        /// dans la collection les véhicules
        /// Retourne null si le véhicule n'est pas dans la collection
        /// </summary>
        /// <param name="pnumero"></param>
        /// <returns></returns>
        
    }
}
