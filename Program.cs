using System;

namespace Expendedora_G3_2021_II
{
    class Program
    {
        static void Main()
        {
            //Expendedora ExpendedoraAWS = new Expendedora();
            /* Expendedora ExpendedoraAWS = new Expendedora(true);
             ExpendedoraAWS.Saludar();
             ExpendedoraAWS.ControlarTiempoDisplay();
             ExpendedoraAWS.MensajeSoporte();
             ExpendedoraAWS.ControlarTiempoDisplay();
             Console.WriteLine("Ingresa la nueva temperatura de la Expendedora");
             byte temperatura = byte.Parse(Console.ReadLine());
             ExpendedoraAWS.Temperatura = temperatura;
             Console.WriteLine("La temperatura de la expendadora es: {0}", ExpendedoraAWS.Temperatura);
            */


            Cafe miExpendedoraCafe = new Cafe(100);


            Console.ReadLine();
        }
    }

}
