using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcMax
{
    class FrequênciaCardiaca
    {

        private char sexo;
        private int idade;

     
        public void setDados(int idade, char sexo)
        {
            this.idade = idade;
            this.sexo = sexo;
        }


        public int CalculaFcMax()
        {

            if (this.sexo == 'F' || this.sexo == 'f')
            {
                int fcf = 226 - idade;
                return fcf;
            }
            else
            {
                int fcm = 220 - idade;
                return fcm;
            }
        }

        internal void setDados()
        {
            throw new NotImplementedException();
        }

        public double IntervaloFcMax_CalculaFcMaxCaminhada()
        {
            double fcf = CalculaFcMax();
            double inter = fcf*0.6;
            return inter;
        }

        public double IntervaloFcMax_CalculaFcMaxCorridaLeve()
        {
            double inter = CalculaFcMax() *0.8;
            return inter;
        }

        public double IntervaloFcMax_CalculaFcMaxCorridaIntensa()
        {
            double inter = CalculaFcMax() *1.0;
            return inter;
        }




    }
}
