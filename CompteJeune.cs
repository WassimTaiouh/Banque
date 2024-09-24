namespace Banque {
     public class CompteJeune : Compte {
         public CompteJeune(String nom) :base(nom) {

         }
         public CompteJeune(String nom , double somme) :this(nom) {
                solde = somme;
         }
        public override void retrait(double somme) {
            if(solde - somme < 0) {
                throw new DecouverteException(); //mettre en découvert
            }
            solde = solde - somme;
        }
    }

    class DecouverteException : Exception {
        public DecouverteException() :base("Découvert interdit") {

        }
        public void displayException() {
            Console.Write(Message);
        }
    }
}