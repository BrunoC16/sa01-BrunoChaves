using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar a variáveis - Média Trimestral
            Decimal jan, fev, mar, mediaTrimestral;

            //Entrada de dados
            jan = 1500;
            fev = 3000;
            mar = 4500;

            //Processamento de dados
            mediaTrimestral = (jan + fev + mar) / 3;

            //Saída de dados
            Console.Write("A média do primeiro trimestre serão: ");
            Console.WriteLine(mediaTrimestral);      
            
            //Parar a tela
            Console.ReadLine();
                
        }
    }
}
