namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bird pasha = new Parrot();
            //Shark akula = new Shark() { Name = "Qaqaw"};
            //Eagle eagle = new Eagle() { Name = "Elxan"};
            //Animal[] animals = {pasha, akula,eagle};
            ////akula.Eat();
            ////akula.Grow();
            //Bird[] birds = { pasha, eagle, new Penguin() };
            //pasha.Eat();
            //akula.Eat();
            //eagle.Fly();
            //pasha.Fly();
            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
            //pasha.Talk();
            //Console.WriteLine(pasha);
            //pasha.Fly();
            MarketCalculation market = new MarketCalculation();
            Console.WriteLine(market.Sum(1, 7));


            ITest t = new Test();
            t.SayHi();
        }
    }
}