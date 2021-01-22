using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcMax
{
    class Program
    {
       

       

        static void Main(string[] args)
        {

            //verificar a classe que está em int e não em double!!!!!!!!


           
            FrequênciaCardiaca Fc = new FrequênciaCardiaca();
            IntervaloFcMax a = new IntervaloFcMax();
            Console.Write("Digite a idade do usuário: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o sexo do usuário: ");
            char sexo = char.Parse(Console.ReadLine());
            Fc.setDados(idade,sexo);
            Console.WriteLine("Frequência máxima: {0}", Fc.CalculaFcMax());
            Console.WriteLine("Intervalo da frequência máxima de uma caminhada: {0}", Fc.IntervaloFcMax_CalculaFcMaxCaminhada());
            Console.WriteLine("Intervalo da frequência de uma corrida leve: {0}", Fc.IntervaloFcMax_CalculaFcMaxCorridaLeve());
            Console.WriteLine("Intervalo da frequência de uma corrida intensa: {0}", Fc.IntervaloFcMax_CalculaFcMaxCorridaIntensa());
            a.conter();

            for (int i =0; i<5;i++)
            {
                Console.WriteLine(a.FcMax[i]);

            }



        }
    }
}
