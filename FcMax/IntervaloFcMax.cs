using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcMax
{
    class IntervaloFcMax
    {

        FrequênciaCardiaca FConter = new FrequênciaCardiaca();
        public double[] FcMin = new double[3];
        public double[] FcMax = new double[3];
        public void conter()
        {
            Program p = new Program();
            p.setAttributes();
            FConter.setDados(p.getIdade(), p.getSexo());
            this.FcMax[0] = FConter.IntervaloFcMax_CalculaFcMaxCaminhada();
            this.FcMin[0] = FConter.CalculaFcMax() * 0.55;
            this.FcMax[1] = FConter.IntervaloFcMax_CalculaFcMaxCorridaLeve();
            this.FcMin[1] = FConter.CalculaFcMax() * 0.75;
            this.FcMax[2] = FConter.IntervaloFcMax_CalculaFcMaxCorridaIntensa();
            this.FcMin[2] = FConter.CalculaFcMax() * 0.95;


            //Se quiser pode rodar um for aqui sem problemas.
            for (int i = 0; i< FcMax.Length;i++)
            {
                Console.WriteLine("Frequênica Máxima : "+i+ " = "+ FcMax[i]);
                Console.WriteLine("Frequência Mínima : " + i + " = " + FcMin[i]+ "\n");

            }





        }




    }
}
