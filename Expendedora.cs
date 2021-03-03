using System;
using System.Threading;

namespace Expendedora_G3_2021_II
{
    class Expendedora
    {
        private string marca;
        private byte temperatura;
        private string codigo;
        private float precio;
        private bool existencia;


        public void Saludar()
        {
            Console.WriteLine( " Bienvenido ");
        }

        public Expendedora()
        {
            marca = "AMS";
            temperatura = 14;
            precio = 10;
            Saludar();
            ControlarTiempoDisplay();
            Console.WriteLine("Marca: {0} ", marca);
            Console.WriteLine("Temperatura interna:  {0} [°C] ", temperatura);
            ControlarTiempoDisplay();
            InteraccionIterativa();
            

        }

        public void InteraccionIterativa()
        {
            int i = 2;
            
            while( !existencia )
            {
                codigo = MostrarCodigoDeProducto(); //Atributo codigo
                ControlarTiempoDisplay();
                MostrarPrecio();
                ControlarTiempoDisplay();
                i--;
                if(i ==0)
                {
                    break;
                }
            }
            ControlarTiempoDisplay();
            Console.WriteLine("Ya no hay productos");
            
        }


        public void ControlarTiempoDisplay()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }

        public string MostrarCodigoDeProducto()
        {
            Console.WriteLine("A1: Snicker \t B2: Papas \t B3: Chips Moradas   ");
            Console.WriteLine("Ingrese el código del producto a elegir");
            string codigo = Console.ReadLine(); // codigo: es una variable local
            return codigo;
        }

        public void MostrarPrecio()
        {
            switch(codigo)
            {
                case  "A1" :
                    Console.WriteLine("El precio es: {0} ",precio );
                    break;
                case "B2" :
                    Console.WriteLine("El precio es: {0} ",precio+5 );
                    break;
                case "B3":
                    Console.WriteLine("El precio es: {0} ", precio + 4 );
                    break;
            }
        }



    }
}
