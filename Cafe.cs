using System;


namespace Expendedora_G3_2021_II
{
    class Cafe:Expendedora
    {
        private short depositoDePolvo;

        public Cafe(short depositoDePolvo)
        {
            this.DepositoDePolvo = depositoDePolvo;

            
            
            ControlarTiempoDisplay();
            Console.WriteLine("El depósito de polvo es: {0} [g]", this.DepositoDePolvo);
        }

        public short DepositoDePolvo {
            get => depositoDePolvo;
            set
            {
                if(value < 100 )
                {
                    depositoDePolvo = 100;
                }
                else
                {
                    depositoDePolvo = value;
                }
                
            }
        }

        public override string MostrarCodigoDeProducto()
        {
            Console.WriteLine("C1: Moka \t C2: Americano \t: C3: Expresso   ");
            Console.WriteLine("Ingrese el Código del producto a elegir");
            string codigo = Console.ReadLine();
            return codigo;
        }

    }
}
