// See https://aka.ms/new-console-template for more information
using CharacterCustomizer;

CharacterManager manager = new CharacterManager();

CostumePiece hat = new HeadPiece("Hat", "Funky", 20, "Head", "Common", false);
CostumePiece fit = new Outfit("Suit", "Dapper", 50, "Torso", "Rare", "Felt");
CostumePiece shoes = new Feet("Sneakers", "Black & white", 20, "Shoes", "Common", false);

Character guy = new Character("SackBoy", 20);
CostumePiece coolHat = new HeadPiece("Cool wig", "very stylish", 25, "Head", "Rare", false);

manager.Add(hat);
manager.Add(fit);
manager.Add(shoes);

Console.WriteLine(guy.Describe());

try
{    
    guy.Equip("Head", coolHat);
    guy.Equip("Torso", fit);
    guy.Equip("Shoes", shoes);
    foreach(var item in manager.CostumeList)
    {
        Console.WriteLine(item.Describe());
    }

}
catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }

try
{
    manager.Add(null);
}
catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }

void Print(IDescribable thing)
{
    Console.WriteLine(thing.Describe());
}

Print(hat);
Print(guy);

manager.CostumeList.Sort();
PrintList("Sort by name");

manager.CostumeList.Sort(new ItemByCostComparer());
PrintList("Sort by cost");
manager.CostumeList.Sort(new ItemByCategoryComparer());
PrintList("Sort by category");
void PrintList(string heading)
{
    Console.WriteLine(heading);
    foreach (CostumePiece piece in manager.CostumeList)
    {
        Console.WriteLine(piece.Name + " | " + piece.GetCategory() + " | " + piece.Cost);
    }
}



object[] b = {hat, guy, "Hi"};
foreach (object thing in b)
{
    if (thing is IDescribable c)
    {  Print(c); }
    else { Console.WriteLine("Not describable"); }
}



//try
//{

//}
//catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }
