namespace EntrepriseRH.Models
{
    public abstract class Employe
    {
        public string Nom { get; set; }
        public double SalaireBase { get; set; }

        
        public Employe(string nom, double salaireBase)
        {
            Nom = nom;
            SalaireBase = salaireBase;
        }

        
        public void AfficherInfos()
        {
            Console.WriteLine($"--- Informations pour {Nom} ---");
            Console.WriteLine($"Type : {this.GetType().Name}");
            Console.WriteLine($"Salaire de base : {SalaireBase:C}");
        }

               public abstract double CalculerSalaireMensuel();
    }
}