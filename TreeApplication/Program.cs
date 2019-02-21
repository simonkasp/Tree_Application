namespace TreeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Saka medis =
                new Saka(1,
                    new Saka(2,
                        new Saka(3)),
                    new Saka(4,
                        new Saka(5,
                            new Saka(6)),
                        new Saka(7,
                            new Saka(8,
                                new Saka(9)),
                            new Saka(10)),
                        new Saka(11))
           );

            medis.GiliausiasLygis();
        }
    }
}
