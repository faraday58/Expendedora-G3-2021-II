using System;


namespace Expendedora_G3_2021_II
{
    class Snack:Expendedora
    {
        public Snack()
        {

            Marca = "AMS";
            Temperatura = 14;
            Precio = 10;
        
            ControlarTiempoDisplay();
            Console.WriteLine("Marca: {0} ", Marca);
            Console.WriteLine("Temperatura interna:  {0} [°C] ", Temperatura);
            ControlarTiempoDisplay();
            InteraccionIterativa();

        }


    }
}
