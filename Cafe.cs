using System;


namespace Expendedora_G3_2021_II
{
    class Cafe:Expendedora
    {
        private short depositoDePolvo;

        public Cafe(short depositoDePolvo)
        {
            this.depositoDePolvo = depositoDePolvo;

            Console.WriteLine("El depósito de polve es: {0}", this.depositoDePolvo);
        }
    }
}
