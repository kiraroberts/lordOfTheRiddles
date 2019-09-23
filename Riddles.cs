using System;
using System.Collections.Generic;


// string[] riddles = {""}
class Riddles
{
  static void Main()
  {
    Console.WriteLine("Answer these riddlessss filthy hobbitsss(all lowercase+singular lol)");

    Dictionary<string, string> riddles = new Dictionary<string, string>() { {"What has roots as nobody sees, Is taller than trees, Up, up it goes, And yet never grows?", "mountain"}, {"Thirty white horses on a red hill, First they champ, Then they stamp, Then they stand still.", "teeth"}, {"Voiceless it cries, Wingless flutters, Toothless bites, Mouthless mutters.", "wind"}, {"It cannot be seen, cannot be felt, Cannot be heard, cannot be smelt. It lies behind stars and under hills, And empty holes it fills. It comes first and follows after, Ends life, kills laughter.", "dark"}, {"A box without hinges, key, or lid, Yet golden treasure inside is hid.", "egg"}, {"Alive without breath, As cold as death; Never thirsty, ever drinking, All in mail never clinking.",  "fish"}, {"This thing all things devours: Birds, beasts, trees, flowers; Gnaws iron, bites steel. Grinds hard stones to meal. Slays king, ruins town, And beats high mountain down.", "time"} };

    Random random = new Random();

    List<string> riddleList = new List<string>(riddles.Keys);

    foreach(var entry in riddleList)
    {
      string randomRiddle = riddleList[random.Next(riddleList.Count)];
      Console.WriteLine(randomRiddle);
      string answer = Console.ReadLine();

      if ((randomRiddle == "What has roots as nobody sees, Is taller than trees, Up, up it goes, And yet never grows?") && (answer == "mountain"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "Thirty white horses on a red hill, First they champ, Then they stamp, Then they stand still.") && (answer == "teeth"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "Voiceless it cries, Wingless flutters, Toothless bites, Mouthless mutters.") && (answer == "wind"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "It cannot be seen, cannot be felt, Cannot be heard, cannot be smelt. It lies behind stars and under hills, And empty holes it fills. It comes first and follows after, Ends life, kills laughter.") && (answer == "dark"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "A box without hinges, key, or lid, Yet golden treasure inside is hid.") && (answer == "egg"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "Alive without breath, As cold as death; Never thirsty, ever drinking, All in mail never clinking.") && (answer == "fish"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else if ((randomRiddle == "This thing all things devours: Birds, beasts, trees, flowers; Gnaws iron, bites steel. Grinds hard stones to meal. Slays king, ruins town, And beats high mountain down.") && (answer == "time"))
      {
        Console.WriteLine("No No No No, Evil, Stupid Hobbitss");
      }
      else
      {
        Console.WriteLine("WRONG");
        break;
      }
    }
  }

}
