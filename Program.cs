using System;

namespace Expendedora_G3_2021_II
{
    class Program
    {
        static void Main()
        {
            //Expendedora ExpendedoraAWS = new Expendedora();
            Expendedora ExpendedoraAWS = new Expendedora(true);
            ExpendedoraAWS.Saludar();
            ExpendedoraAWS.ControlarTiempoDisplay();
            ExpendedoraAWS.MensajeSoporte();


            Console.ReadLine();
        }
    }

}
