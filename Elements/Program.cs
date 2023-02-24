namespace Elements
{
    internal class Program
    {
        
        public class Element
        {
            // Fields
            public string name;
            public int Z;
            public string category;
            public double meltingPoint;
            public double boilingPoint;

            // Constructor
            public Element(string name, int z, string category, double meltingPoint, double boilingPoint)
            {
                this.name = name;
                this.Z = z;
                this.category = category;
                this.meltingPoint = meltingPoint;
                this.boilingPoint = boilingPoint;
            }

            // Print method for presenting element data
            public void Print()
            {
                Console.WriteLine($"Element: {this.name}");
                Console.WriteLine($"    category: {this.category}");
                Console.WriteLine($"    melting point: {this.meltingPoint} K");
                Console.WriteLine($"    boiling point: {this.boilingPoint} K");
            }
        }
        static void Main(string[] args)
        {
            // welcome
            Console.WriteLine("Welcome to Elements");
            Console.WriteLine("===================\n");

            // three instances: oxygen, iron and gold
            Element oxygen = new Element("Oxygen", 8, "non-metal", 54.36, 90.188);
            Element iron = new Element("Iron", 26, "metal", 1811, 3134);
            Element gold = new Element("Gold", 79, "metal", 1337.33, 3243);

            // print element data for oxygen, iron and gold
            oxygen.Print();
            iron.Print();
            gold.Print();
            
        }
    }
}