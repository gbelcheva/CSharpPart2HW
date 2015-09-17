namespace ZooExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZooExample.Adapters;
    using ZooExample.Animals;
    using ZooExample.Contracts;

    public class StartPoint
    {
        public static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();

            Console.WriteLine("This Zoo has mallard ducks. This one says:");
            mallardDuck.Quack();
            Console.WriteLine("Mallard ducks can fly very well, see how this one can fly:");
            mallardDuck.Fly();

            Console.WriteLine(
                "Unfortunately, all the ducks in the Zoo got sick with H5N1 avian flu!\n" +
                "Now the Zoo wants to substitute the mallard ducks with an H5N1 resistant bird. They get wild turkeys.\n" + 
                "Hey, turkey, can you quack?\n" + 
                "...\n" + 
                "I guess not. How about gobble?");

            ITurkey wildTurkey = new WildTurkey();
            wildTurkey.Gobble();

            Console.WriteLine("Great... This is really not good. Someone might notice the gobbling! But lets see if this one can at least fly well:");
            wildTurkey.Fly();

            Console.WriteLine(
                "This is a disaster, it can't even fly well!\n" + 
                "The Zoo decides to hire a bird-trainer to show the wild turkeys how to behave more like real mallard ducks.");

            TurkeyToDuckAdapter turkeyInDuckDisguise = new TurkeyToDuckAdapter(wildTurkey);

            Console.WriteLine("Let's try again. Come on, turkey, quack!");
            turkeyInDuckDisguise.Quack();
            Console.WriteLine("Well, it still sounds like \"gibble-gobble\" to me, but the children won't notice. At least the turkey knows when it should quack. Now fly!");
            turkeyInDuckDisguise.Fly();
            Console.WriteLine("Oh, well! It still can't fly very well either, but at least it tries... I am sure no one will notice!");
        }
    }
}
