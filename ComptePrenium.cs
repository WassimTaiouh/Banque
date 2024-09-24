namespace Banque {

    public class ComptePrenium : Compte {
        private double DecouvertAutorise {get; set;}
        public ComptePrenium(String nom) :base(nom) {
            DecouvertAutorise = 500;
        }
        public ComptePrenium(String nom, double somme) :base(nom , somme) {
            DecouvertAutorise = 500;
        }
         public override void retrait(double somme) {
            if(solde - somme < DecouvertAutorise*(-1)) {
                throw new DecouverteException();
            }
            solde = solde - somme;
        }
    }
}