class Program
{
    static void Main(string[] args)
    {
        VGA vga1 = new VGA("Nvidia");
        Processor intel1 = new Processor("Intel", "Corei5");
        Laptop laptop1 = new Vivobook("ASUS", "Vivobook", vga1, intel1);
        ((Vivobook)laptop1).Ngoding();
        Console.WriteLine($"Laptop {laptop1.merk} {laptop1.tipe} menggunakan merek vga {laptop1.vga.merk} dan menggunakan processor bermerk {laptop1.processor.merk} dengan tipe {laptop1.processor.tipe}");

        VGA vga2 = new VGA("AMD");
        Processor amd1 = new Processor("AMD", "Ryzen");
        Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", vga2, amd1);
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Processor intel2 = new Processor("Intel", "Corei7");
        Predator predator = new Predator("ACER", "Predator", vga2, intel2);
        predator.BermainGame();

        ACER acer = new Predator("ACER", "Predator", vga2, intel2);
        ((Predator)acer).BermainGame();
    }
}

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public string merk = "Intel";
    public Intel(string merk, string tipe) : base(merk, tipe)
    {
        this.merk = merk;
    }
}
class CoreI3 : Intel
{
    public string tipe = "Core i3";
    public CoreI3(string merk, string tipe) : base(merk, tipe)
    {
        this.tipe = tipe;
    }
}
class CoreI5 : Intel
{
    public string tipe = "Core i5";
    public CoreI5(string merk, string tipe) : base(merk, tipe)
    {
        this.tipe = tipe;
    }
}
class CoreI7 : Intel
{
    public string tipe = "Core i7";
    public CoreI7(string merk, string tipe) : base(merk, tipe)
    {
        this.tipe = tipe;
    }
}

class AMD : Processor
{
    public string merk = "AMD";
    public AMD(string merk, string tipe) : base(merk, tipe)
    {
        this.merk = merk;
    }
}
class Ryzen : AMD
{
    public string tipe = "RAYZEN";
    public Ryzen(string merk, string tipe) : base(merk, tipe)
    {
        this.tipe = tipe;
    }
}
class Athlon : AMD
{
    public string tipe = "ATHLON";
    public Athlon(string merk, string tipe) : base(merk, tipe)
    {
        this.tipe = tipe;
    }
}

class VGA
{
    public string merk;
    public VGA(string merk)
    {
        this.merk = merk;
    }
}
class Nvidia : VGA
{
    public string merk = "Nvidia";
    public Nvidia(string merk) : base(merk)
    {
        this.merk = merk;
    }
}
class AMD1 : VGA
{
    public string merk = "AMD";
    public AMD1(string merk) : base(merk)
    {
        this.merk = merk;
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;

    public Laptop(string merk, string tipe, VGA vga, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
}

class ASUS : Laptop
{
    public string merk;
    public ASUS(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.merk = merk;
    }
}
class ROG : ASUS
{
    public string tipe = "ROG";
    public ROG(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
}
class Vivobook : ASUS
{
    public string tipe = "Vivobook";
    public Vivobook(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!");
    }
}

class ACER : Laptop
{
    public string merk;
    public ACER(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.merk = merk;
    }
}
class Swift : ACER
{
    public string tipe = "Swift";
    public Swift(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
}
class Predator : ACER
{
    public string tipe = "Predator";
    public Predator(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {base.merk} {this.tipe} sedang bermain game");
    }
}

class Lenovo : Laptop
{
    public string merk;
    public Lenovo(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.merk = merk;
    }
}
class IdeaPad : Lenovo
{
    public string tipe = "IdeaPad";
    public IdeaPad(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
}
class Legion : Lenovo
{
    public string tipe = "Legion";
    public Legion(string merk, string tipe, VGA vga, Processor processor) : base(merk, tipe, vga, processor)
    {
        this.tipe = tipe;
    }
}