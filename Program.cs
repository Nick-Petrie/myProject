using System;
using System.Diagnostics;

namespace myProject
{
    class game
    {
        private double _Price;
        private string _Title;
        private string _Genre;
        public game()
        {
            _Price = 0;
            _Title = "";
            _Genre = "";
        }

        public game(double price, string title, string genre)
        {
            _Price = price;
            _Title = title;
            _Genre = genre;
        }
        public double GetPrice()
        {
            return _Price;
        }

        public void SetPrice(double price)
        {
            _Price = price;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetGenre()
        {
            return _Genre;
        }

        public void SetGenre(string genre)
        {
            _Genre = genre;
        }

    }
    class myStore
    {
        static void Main(string[] args)
        {
            game game1 = new game();
            game1.SetPrice(19.99);
            game1.SetTitle("Minecraft");
            game1.SetGenre("Sandbox");

            game game2 = new game();
            Console.WriteLine("Please enter your game's price");
            game2.SetPrice(double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your game's title");
            game2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter your game's genre");
            game2.SetGenre(Console.ReadLine());

            game game3 = new game(0, "Call of Duty: Warzone", "First Person Shooter, Battle Royale");
            Console.WriteLine("Please enter your game's price");
            double tempId = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your game's title");
            string tempTitle = (Console.ReadLine());
            Console.WriteLine("Please enter your game's genre");
            string tempGenre = (Console.ReadLine());
            game game4 = new game(tempId, tempTitle, tempGenre);

            displaygames(game1);
            displaygames(game2);
            displaygames(game3);
            displaygames(game4);
        }
        static void displaygames(game game)
        {
            Console.WriteLine("Here is all off your games' information");
            Console.WriteLine($"Game Price: {game.GetPrice()}");
            Console.WriteLine($"Game Title: {game.GetTitle()}");
            Console.WriteLine($"Game Genre: {game.GetGenre()}");
        }



    }

}