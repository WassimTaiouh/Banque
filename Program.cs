using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
         CompteJeune compte1 = new CompteJeune("Ali" , 200);
         ComptePrenium compte2 = new ComptePrenium("Wassim" , 200);
         CompteEpargne compte3 = new CompteEpargne("DemonSlayer" , 200);
         try {
               Console.WriteLine($"Compte de  {compte1.Titulaire} a une solde de :{compte1.Solde}"  );
                compte1.retrait(200);
                Console.WriteLine($"Compte de  {compte2.Titulaire} a une solde de :{compte2.Solde}"  );
                compte2.retrait(700);
                Console.WriteLine($"Compte de  {compte3.Titulaire} a une Epargne de :{compte3.Solde}"  );
                compte3.depot(100);
         } catch(DecouverteException de) {
            de.displayException();
         }
            Console.WriteLine($"Compte de  {compte1.Titulaire} a une solde de :{compte1.Solde}"  );
             Console.WriteLine($"Compte de  {compte2.Titulaire} a une solde de :{compte2.Solde}"  );
             Console.WriteLine($"Compte de  {compte3.Titulaire} a une Epargne de :{compte3.Solde}"  );
        }

    }
}