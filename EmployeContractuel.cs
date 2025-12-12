namespace EntrepriseRH.Models
{
    public class EmployeContractuel : Employe, IAuditeur
    {
        public int NombreMoisRestants { get; set; }

        public EmployeContractuel(string nom, double salaireBase, int nombreMoisRestants)
            : base(nom, salaireBase)
        {
            NombreMoisRestants = nombreMoisRestants;
        }

        public override double CalculerSalaireMensuel()
        {
            double prime = 0.05 * NombreMoisRestants;
            double salaireMensuel = SalaireBase + (SalaireBase * prime);
            
            Console.WriteLine($"Calcul du salaire contractuel: Base + {prime * 100:N0}% ({NombreMoisRestants} mois restants).");
            return salaireMensuel;
        }

        public void Auditer()
        {
            Console.WriteLine($"{Nom} (Contractuel) procède à l'audit du service des finances.");
        }
    }
}