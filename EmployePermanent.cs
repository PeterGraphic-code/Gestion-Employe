namespace EntrepriseRH.Models
{
    public class EmployePermanent : Employe, IFormateur
    {
        public EmployePermanent(string nom, double salaireBase) : base(nom, salaireBase)
        {
        }

        public override double CalculerSalaireMensuel()
        {
            double salaireMensuel = SalaireBase * 1.15;
            Console.WriteLine($"Calcul du salaire permanent: Salaire Base + 15% Prime.");
            return salaireMensuel;
        }

        public void Former()
        {
            Console.WriteLine($"{Nom} (Permanent) est en train d'organiser une session de formation.");
        }
    }
}