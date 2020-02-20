
using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinosaurTracker
  {
    public List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();




    public void AddNewDinosaur(string name, string dietType, int weight, int enclosureNumber)
    {
      var dinosaur = new Dinosaur
      {
        Name = name,
        DietType = dietType,
        Weight = weight,
        EnclosureNumber = enclosureNumber
      };
      Dinosaurs.Add(dinosaur);
    }

    public void RemoveDinosaur(string name)
    {
      var dinoToRemove = Dinosaurs.Where(Dinosaurs => Dinosaurs.Name == name).ToList();
      if (dinoToRemove.Count > 1)
      {
        Console.WriteLine($"There is more than one {name}, which one do you want to remove?");
        for (var i = 0; i < dinoToRemove.Count; i++)
        {
          var dino = dinoToRemove[i];
          Console.WriteLine($"{i + 1}: {dino.EnclosureNumber} at ${dino.EnclosureNumber}");
        }

      }
      else
      {
        Dinosaurs.Remove(dinoToRemove.First());
      }
    }
    public void TransferDinosaur(string name)
    {
      var dinoPen = Dinosaurs.First(name => Dinosaurs.Contains(name)).EnclosureNumber;
      Console.WriteLine($"{name} is in enclosure {dinoPen}");
      Console.WriteLine("Where do you want to move it?");
      var newPen = int.Parse(Console.ReadLine());
      Dinosaurs.First(name => Dinosaurs.Contains(name)).EnclosureNumber = newPen;
    }
    public void HeavyDino()
    {
      var heavyDino = Dinosaurs.OrderByDescending(Dinosaurs => Dinosaurs.Weight).Take(3);
      // foreach (var dino in heavyDino)
      // {
      //   Console.WriteLine($"{dino.Name} weighs {dino.Weight} ");
      // }
    }
    public void DisplayDiet()
    {
      var vegDino = Dinosaurs.Where(Dinosaurs => Dinosaurs.DietType.Contains("herbivore")).ToList();
      Console.WriteLine($"There are {vegDino.Count} herbivores");

      var meatDino = Dinosaurs.Where(Dinosaurs => Dinosaurs.DietType.Contains("carnivore")).ToList();
      Console.WriteLine($"These are {meatDino.Count} carnivores");

    }
  }
}