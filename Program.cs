using System;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Jurassic Park");
      var tracker = new DinosaurTracker();
      var powerIsOn = true;
      while (powerIsOn)
      {


        Console.WriteLine("Do you want to see a (LIST) dinosaurs, (ADD), (REMOVE), (TRANSFER) or (QUIT) ");
        var input = Console.ReadLine().ToLower();
        if (input == "add")
        {
          Console.WriteLine("What dinosaur do you want to add?");
          var name = Console.ReadLine().ToLower();
          Console.WriteLine("Is it a (HERBIVORE) or (CARNIVORE)?");
          var dietType = Console.ReadLine().ToLower();
          Console.WriteLine("How heavy is it?");
          var weight = int.Parse(Console.ReadLine().ToLower());
          Console.WriteLine("What enclosure is it in?");
          var enclosureNumber = int.Parse(Console.ReadLine().ToLower());

          tracker.AddNewDinosaur(name, dietType, weight, enclosureNumber);
        }
        else if (input == "list")
        {
          Console.WriteLine("Do you want to see a (FULL) list, three (HEAVIEST) list or (DIET) type list?");
          var view = Console.ReadLine().ToLower();
          if (view == "full")
          {
            Console.WriteLine("Here is a list of all the dinosaurs in Jurassic Park");
            foreach (var d in tracker.Dinosaurs)
            {
              Console.WriteLine($"Acquired on: {d.DateAcquired}, Name: {d.Name}, Weight: {d.Weight}, Diet: {d.DietType}, Enclosure {d.EnclosureNumber}");
            }
          }
          else if (view == "heaviest")
          {
            Console.WriteLine("These are the three heaviest dinosaurs");
            tracker.HeavyDino();
          }
          else if (view == "diet")
          {
            tracker.DisplayDiet();
          }
        }

        else if (input == "remove")
        {
          Console.WriteLine("What dinosaur do you want to remove?");
          var name = Console.ReadLine().ToLower();


          tracker.RemoveDinosaur(name);
        }
        else if (input == "transfer")
        {
          Console.WriteLine("What dinosaur do you want to move?");
          var name = Console.ReadLine().ToLower();
          tracker.TransferDinosaur(name);

        }
        else if (input == "quit")
        {
          powerIsOn = false;
        }
      }
    }
  }
}
