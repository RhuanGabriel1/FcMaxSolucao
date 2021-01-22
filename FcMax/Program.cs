using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcMax
{
    class Program
    {

         private char sexo;
         private int idade;

        public  char getSexo()
        {
            return sexo;
        }
        public  int getIdade()
        {
            return idade;
        }


        public void setAttributes()
        {
            FrequênciaCardiaca Fc = new FrequênciaCardiaca();

            Console.Write("Digite a idade do usuário: ");
             
            idade = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o sexo do usuário: ");
             sexo = char.Parse(Console.ReadLine());
            Fc.setDados(idade, sexo);

            Console.WriteLine("Frequência máxima: {0}", Fc.CalculaFcMax());
            Console.WriteLine("Intervalo da frequência máxima de uma caminhada: {0}", Fc.IntervaloFcMax_CalculaFcMaxCaminhada());
            Console.WriteLine("Intervalo da frequência de uma corrida leve: {0}", Fc.IntervaloFcMax_CalculaFcMaxCorridaLeve());
            Console.WriteLine("Intervalo da frequência de uma corrida intensa: {0}", Fc.IntervaloFcMax_CalculaFcMaxCorridaIntensa());
            
            //não execute esse for na main, execute onde você faz o metódo.. assim você poupa o código e faz ele rodar com menor gargalos
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(a.FcMax[i]);

            //}

        }
        static void Main(string[] args)
        {
            //verificar a classe que está em int e não em double!!!!!!!!
            IntervaloFcMax intervalo = new IntervaloFcMax();
            intervalo.conter();
        }
    }
}
