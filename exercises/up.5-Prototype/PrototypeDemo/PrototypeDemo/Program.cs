using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code to demonstrate the classic Prorotype Pattern
            NovelHero player = new NovelHero();
            player.Health = 1;
            player.Courage = 10;
            player.Money = 2.0;

            Console.WriteLine("Original Player stats:");
            Console.WriteLine("Health: {0}, Courage: {1}, Money: {2}", 
                player.Health.ToString(),
                player.Courage.ToString(), 
                player.Money.ToString());

            // We enter the cheat code here and we have a new 
            // player with his health fully restored.
            NovelHero playerToSave = player.Clone() as NovelHero;            

            Console.WriteLine("\nCopy of player to save on disk:");
            Console.WriteLine("Health: {0}, Courage: {1}, Money: {2}", 
                playerToSave.Health.ToString(),
                playerToSave.Courage.ToString(), 
                playerToSave.Money.ToString());

            PerformShallowCopy();
            
            PerformDeepCopy();

            ICloneableVersionCopy();

        }

        private static void PerformShallowCopy()
        {
            // The code to demonstrate the shallow copy
            OtherHero playerEx = new OtherHero();
            playerEx.Health = 1;
            playerEx.Courage = 10;
            playerEx.Money = 2.0;
            playerEx.Details.Fitness = 5;
            playerEx.Details.Charisma = 5;

            // Lets clone the above object and change the 
            // proprties of contained object
            OtherHero shallowClonedPlayer = playerEx.Clone() as OtherHero;
            shallowClonedPlayer.Details.Charisma = 10;
            shallowClonedPlayer.Details.Fitness = 10;

            // Lets see what happened to the original object
            Console.WriteLine("\nOriginal Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                playerEx.Details.Charisma.ToString(),
                playerEx.Details.Fitness.ToString());
            Console.WriteLine("\nShallow Cloned Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                shallowClonedPlayer.Details.Charisma.ToString(),
                shallowClonedPlayer.Details.Fitness.ToString());
        }

        private static void PerformDeepCopy()
        {
            // Let us see how we can perform the deep copy now
            OtherHero playerEx2 = new OtherHero();
            playerEx2.Health = 1;
            playerEx2.Courage = 10;
            playerEx2.Money = 2.0;
            playerEx2.Details.Fitness = 5;
            playerEx2.Details.Charisma = 5;

            // lets clone the object but this time perform a deep copy
            OtherHero shallowClonedPlayer2 = playerEx2.Clone() as OtherHero;
            shallowClonedPlayer2.Details.Charisma = 10;
            shallowClonedPlayer2.Details.Fitness = 10;

            // Lets see what happened to the original object
            Console.WriteLine("\nOriginal Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                playerEx2.Details.Charisma.ToString(),
                playerEx2.Details.Fitness.ToString());
            Console.WriteLine("\nDeep Cloned Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                shallowClonedPlayer2.Details.Charisma.ToString(),
                shallowClonedPlayer2.Details.Fitness.ToString());
        }

        private static void ICloneableVersionCopy()
        {
            // Let us see how we can perform the deep copy now
            NovelHeroFinal player = new NovelHeroFinal();
            player.Health = 1;
            player.Courage = 10;
            player.Money = 2.0;
            player.Details.Fitness = 5;
            player.Details.Charisma = 5;

            // lets clone the object but this time perform a deep copy
            NovelHeroFinal clonedPlayer = player.Clone() as NovelHeroFinal;
            clonedPlayer.Details.Charisma = 10;
            clonedPlayer.Details.Fitness = 10;

            // Lets see what happened to the original object
            Console.WriteLine("\nOriginal Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                player.Details.Charisma.ToString(),
                player.Details.Fitness.ToString());
            Console.WriteLine("\nICloneable Deep Cloned Object:");
            Console.WriteLine("Charisma: {0}, Fitness: {1}",
                clonedPlayer.Details.Charisma.ToString(),
                clonedPlayer.Details.Fitness.ToString());
        }
    }
}
