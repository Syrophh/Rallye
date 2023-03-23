using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rallye
{
    class Program
    {
        static void Main(string[] args)
        {
            Rallye rallyeDuVar = new Rallye("Rallye du Var", 80);
            rallyeDuVar.AjouterVehicule(chargeVehicules());
            Console.WriteLine(rallyeDuVar.VehiculeInscrit(100));  // true
            Console.WriteLine(rallyeDuVar.VehiculeInscrit(106)); //true
            Console.WriteLine(rallyeDuVar.VehiculeInscrit(113));  //true
            Console.WriteLine(rallyeDuVar.VehiculeInscrit(144));  //false



        }

        public static List<Vehicule> chargeVehicules()
        {
            List<Vehicule> vehicules = new List<Vehicule>();
            vehicules.Add(new Vehicule(100, "Renault", "Clio"));
            vehicules.Add(new Vehicule(103, "Renault", "Clio"));
            vehicules.Add(new Vehicule(106, "Alpine", "A110"));
            vehicules.Add(new Vehicule(107, "Alpine", "A110"));
            vehicules.Add(new Vehicule(110, "Lancia", "Startos"));
            vehicules.Add(new Vehicule(112, "Lancia", "Startos"));
            vehicules.Add(new Vehicule(113, "Simca", "Rallye 3"));
            return vehicules;
        }
    }
}
