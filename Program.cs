// See https://aka.ms/new-console-template for more information
using CharacterCustomizer;


Character guy = new Character("SackBoy", 20);
CostumePiece coolHat = new HeadPiece("Cool wig", "very stylish", 25, "Head", "Rare", false);
try
{    
    guy.Equip("Torso", coolHat);

    foreach(var item in guy.Wearing)
    {
        Console.WriteLine(item.Describe());
    }

}
catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }


//try
//{
    
//}
//catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }
