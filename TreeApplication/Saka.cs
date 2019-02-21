using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeApplication
{
    public class Saka
    {
        private List<Saka> sakos = new List<Saka>();
        private readonly int sk;
        private Saka pagrindineSaka;

        public int VaikuSkaicius
        {
            get { return sakos.Count(); }
        }

        public Saka(int sk)
        {
            this.sk = sk;
        }

        public Saka(int sk, params Saka[] sakos)
            : this(sk)
        {
            
            pagrindineSaka = new Saka(sk);

            foreach (Saka vaikas in sakos)
            {
                pagrindineSaka.PridetiVaika(vaikas.pagrindineSaka);
            }
        }

        public void PridetiVaika(Saka vaikas)
        {
            sakos.Add(vaikas);
        }

        public Saka GautiVaika(int index)
        {
            return sakos[index];
        }

        public void GiliausiasLygis()
        {
            Console.Write("Giliausias lygis: ");
            Console.WriteLine(GiliausiasLygis(pagrindineSaka, 1));
        }

        private int GiliausiasLygis(Saka pagrindineSaka, int gylis)
        {
            Saka vaikas;

            if (pagrindineSaka == null)
                return 0;
            
            int rezultatas = gylis + 1;

            for (int i = 0; i < pagrindineSaka.VaikuSkaicius; i++)
            {
                vaikas = pagrindineSaka.GautiVaika(i);
                rezultatas = Math.Max(rezultatas, GiliausiasLygis(vaikas, gylis + 1));
            }

            return rezultatas;
        }

    }
}
