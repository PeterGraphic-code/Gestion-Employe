namespace EntrepriseRH.Models
{
    public class ConsultantFreelance : Employe, IFacturable
    {
        public int JoursTravailles { get; set; }
        
        public ConsultantFreelance(string nom, double tauxJournalierMoyen, int joursTravailles)
            : base(nom, tauxJournalierMoyen)
        {
            JoursTravailles = joursTravailles;
        }

        public override double CalculerSalaireMensuel()
        {
            double salaire = SalaireBase * JoursTravailles;
            Console.WriteLine($"Calcul du Freelance : TJM ({SalaireBase:C}) x Jours Travaillés ({JoursTravailles}j).");
            return salaire;
        }

        public void GenererFacture()
        {
            Console.WriteLine($"{Nom} (Freelance) vient de générer une facture pour {JoursTravailles} jours de travail.");
        }
    }
}