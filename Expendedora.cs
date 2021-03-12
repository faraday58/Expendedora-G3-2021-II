using System;
using System.Threading;

namespace Expendedora_G3_2021_II
{
    abstract class Expendedora
    {
        private string marca;
        private byte temperatura;
        private string codigo;
        private float precio;
        private bool existencia;

        //Propiedad de la temperatura
        public byte Temperatura {
            get => temperatura;
            set
            {
                if (value < 14 || value > 19)
                {
                    temperatura = 14;
                } else
                {
                    temperatura = value;
                }

            }
        }

        public string Marca {
            get
            {
                return marca;
            }
            set
            {
                if (value == "")
                {
                    marca = "AWS";
                }
                else
                {
                    marca = value;
                }

            }
        }

        public float Precio {
            get => precio;
            set
            {
                if (value < 0)
                {
                    precio = 10;
                }
                else
                {
                    precio = value;
                }

            }
        }

        public void Saludar()
        {
            Console.WriteLine(" Bienvenido ");
        }
        public void MensajeSoporte()
        {
            Console.WriteLine("Entrando en modo soporte");
        }



        public Expendedora()
        {
            Saludar();
        }

        public Expendedora(bool soporte)
        {
            if (soporte)
            {
                MensajeSoporte();
            }

        }
        public Expendedora(string marca)
        {
            this.marca = marca;
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

        public virtual string MostrarCodigoDeProducto()
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
                    Console.WriteLine("El precio es: {0} ",Precio );
                    break;
                case "B2" :
                    Console.WriteLine("El precio es: {0} ",Precio+5 );
                    break;
                case "B3":
                    Console.WriteLine("El precio es: {0} ", Precio + 4 );
                    break;
            }
        }



    }



    
}
