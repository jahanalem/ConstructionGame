namespace ConstructionGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructionGame game = new ConstructionGame(2, 2);
            game.AddCubes(new bool[,]
            {
                { true, true },
                { true, true }
            });
            game.AddCubes(new bool[,]
            {
                { true, true },
                { true, true }
            });
            game.AddCubes(new bool[,]
            {
                { true, true },
                { false, false }
            });
            game.AddCubes(new bool[,]
            {
                { true, true },
                { false, true }
            });
            Console.WriteLine(game.GetHeight()); // Should print 2

            game.AddCubes(new bool[,]
            {
                { false, false },
                { true, true }
            });
            Console.WriteLine(game.GetHeight()); // Should print 1

            game.AddCubes(new bool[,]
            {
                { false, false },
                { true, false }
            });
            Console.WriteLine(game.GetHeight()); // Should print 0
        }
    }
}
