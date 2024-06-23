using System;
using System.Linq;
using System.Collections.Generic;

namespace WHERE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Calcul de la moyenne d'une liste de nombre. 

            Console.WriteLine("Donner un nombre dont on prendra les valeurs inferieures");
            Console.WriteLine("pour calculer la moyenne. ");
            int n=Convert.ToInt32(Console.ReadLine());
            List<int> integers = new List<int> { 1, 20, 35, 514, 155, 56, 24, 878, 99 ,300};
            List<int> integersLowerThanN = integers.Where((x) => x < n).ToList();

            double average = integersLowerThanN.Average();
            Console.WriteLine("La moyenne est : "+average);
        }
    }
}