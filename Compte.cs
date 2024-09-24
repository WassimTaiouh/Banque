namespace Banque {

   public  abstract class Compte {
        protected double solde;
        public double Solde
        {
            get { return solde; }
        }
        protected String titulaire;
        public String Titulaire
        {
            get{return titulaire;}
            set{titulaire = value;}
        }
        public Compte(String nom) {
            titulaire= nom;
        }
        public Compte(String nom , double solde) :this(nom){
            this.solde = solde;
        }
        public abstract void retrait(double somme);

        public virtual void depot(double somme) {
            somme += somme;
        }
    }
}