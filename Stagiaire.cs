namespace EntrepriseRH.Models
{
    public class Stagiaire : Employe
    {
        public Stagiaire(string nom, double salaireBase) : base(nom, salaireBase)
        {
        }

        public override double CalculerSalaireMensuel()
        {
            double salaireMensuel = SalaireBase * 0.60; 
            Console.WriteLine("Calcul du salaire stagiaire: 60% du Salaire Base.");
            return salaireMensuel;
        }
    }
}