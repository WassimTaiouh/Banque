namespace Banque {
     public class CompteEpargne : Compte {

         private double tauxinteret {get; set;}
         public CompteEpargne(String nom) :base(nom) {
                tauxinteret = 10;
         }
         public CompteEpargne(String nom , double somme) :base(nom , somme) {
                tauxinteret = 10;
         }
        public override void retrait(double somme) {
            if(solde - somme < 0) {
                throw new DecouverteException();
            }
            solde = solde - somme;
        }
           public override void depot(double montant) {
            double somme = montant + montant * (tauxinteret / 100);
            base.depot(somme);

        }
    }
}