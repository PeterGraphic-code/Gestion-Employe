using EntrepriseRH.Models;
using System.Collections.Generic; 

namespace EntrepriseRH
{
    class Program
    {
        static void Main(string[] args)
        {
           
            EmployePermanent peter = new EmployePermanent("Peter Graphic", 50000);
            EmployeContractuel bony = new EmployeContractuel("Bony Badio", 35000, 6);
            Stagiaire betty = new Stagiaire("Betty Chery", 20000);
            EmployePermanent douda = new EmployePermanent("Douda Jameson", 62000);
            
          
            ConsultantFreelance petion = new ConsultantFreelance("Petion Alexandre", 8000, 15); 
            Employe[] entreprise = new Employe[]
            {
                peter,
                bony,
                betty,
                douda,
                petion
            };

            Console.WriteLine("\n--- PARTIE 3 & 4 : Analyse de tous les Employés ---");
            
            foreach (var employe in entreprise)
            {
                employe.AfficherInfos(); 
                Console.WriteLine($"Type concret : {employe.GetType().Name}"); 
                
                double salaireReel = employe.CalculerSalaireMensuel();
                Console.WriteLine($"Salaire mensuel réel: {salaireReel:C}");
                
                if (employe is IFormateur formateur)
                {
                    Console.WriteLine("Capacité : Peut former.");
                }
                if (employe is IAuditeur auditeur)
                {
                    Console.WriteLine("Capacité : Peut auditer.");
                }
                
                if (employe is IFacturable facturable)
                {
                    Console.Write("Capacité : ");
                    facturable.GenererFacture();
                }
                
                Console.WriteLine("--------------------------------------------------\n");
            }
        }

    }
}