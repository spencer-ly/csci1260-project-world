// See https://aka.ms/new-console-template for more information
using CharacterCustomizer;



class Program
{
    static void Main(string[] args)
    {

        //          === Relationships ===

        Console.WriteLine("=== Character Customizer ===");
        Console.WriteLine();

        CharacterManager manager = new CharacterManager();
        Character sackboy = new Character("SackBoy", 100);
        
        sackboy.Style.Skin = "Denim";
        sackboy.Style.Color = "Blue"; //Composition
        sackboy.Style.Eyes = "Lashes";

        CostumePiece coolHat = new HeadPiece("Cool Hat", "Funky", 20, "Head", "Common", false);
        CostumePiece dapperSuit = new Outfit("Dapper Suit", "Snazzy", 60, "Torso", "Rare", "Felt");
        CostumePiece sneakers = new Feet("Kicks", "Stylish", 40, "Shoes", "Developer Only", false);

        try
        {
            CostumePiece badHat = new HeadPiece("Bad Hat", "Bad", 30, "Shoes", "Common", false);
        }
        catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }

        try
        {
            CostumePiece badOutfit = new Outfit("Bad Outfit", "Bad", -15, "Torso", "Common", "Burlap");
        }
        catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }

        manager.Add(coolHat);
        manager.Add(dapperSuit);
        manager.Add(sneakers);

        //          === Polymorphism and Interfaces ===
        foreach (CostumePiece item in manager.CostumeList)
        {
            Console.WriteLine(item.Describe());
        }

        try
        {
            sackboy.Wear("Torso", sneakers);
        }
        catch (InvalidItemException ex) { Console.WriteLine(ex.Message); }
        sackboy.Describe();

        object[] a = { coolHat, sackboy, dapperSuit };
        foreach (object thing in a)
        {
            if (thing is IDescribable b)
            { Print(b); }
            else { Console.WriteLine("Not describable"); }
        }

        void Print(IDescribable thing)
        {
            Console.WriteLine(thing.Describe());
        }


        Print(sackboy); 
        Print(dapperSuit);

        void PrintList(string header)
        {
            Console.WriteLine(header);
            foreach (CostumePiece piece in manager.CostumeList)
            {
                Console.WriteLine(piece.Name + " | " + piece.GetCategory() + " | " + piece.Cost);
            }
        }

        sackboy.Wear("Head", coolHat);
        sackboy.Wear("Torso", dapperSuit);
        sackboy.Wear("Shoes", sneakers);
        Print(sackboy);

        Console.WriteLine("================");

        manager.CostumeList.Sort();
        PrintList("Sort by name:");



        manager.CostumeList.Sort(new ItemByCostComparer());
        PrintList("Sort by cost:");

        manager.CostumeList.Sort(new ItemByCategoryComparer());
        PrintList("Sort by category:");

        List<ItemRecord> itemRecords = new List<ItemRecord>();
        foreach (CostumePiece record in manager.CostumeList)
        {
            itemRecords.Add(new ItemRecord(record.Name, record.GetCategory()));
        }

        itemRecords.Add(new ItemRecord("Cool Hat", "HeadPiece"));

        Console.WriteLine("Before Hash: " + itemRecords.Count);

        HashSet<ItemRecord> itemsHash = new HashSet<ItemRecord>(itemRecords);
        Console.WriteLine("After Hash: " + itemsHash.Count);

        Log log = null;
        try
        {
            using (log = new Log("log.txt"))
            {
                for (int i = 0; i < 3; i++)
                    log.Write(itemRecords[i]);
                throw new InvalidItemException("fault after 3 writes");
            }
        }
        catch (InvalidItemException ex) { Console.WriteLine("  Caught: " + ex.Message); }

        bool safeTwice = true;
        try { log.Dispose(); } catch { safeTwice = false; }

        string recordLog = String.Format("    {0,-50}{1,6}", "The log closed itself?", log.IsClosed);
        string recordLog2 = String.Format("    {0,-50}{1,6}", "Closing it a second time was safe?", safeTwice);
        string recordLog3 = String.Format("    {0,-50}{1,6}", "Lines the log wrote before the fault:", log.Count);

        string[] file = File.ReadAllLines("log.txt");

        Console.WriteLine(recordLog);
        Console.WriteLine(recordLog2);
        Console.WriteLine(recordLog3);

        Console.WriteLine("   log.txt now says:");
        foreach (string line in file)
        {
            string lines = String.Format("    {0}", line);
            Console.WriteLine(lines);
        }



    }
}