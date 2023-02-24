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
            Console.WriteLine("Printing 3 instances of class Element");
            oxygen.Print();
            iron.Print();
            gold.Print();

            // array with 6 element, adding the instances of oxygen, iron and gold
            // plus the new hydrogen, bromine and mercury
            Element[] elements = new Element[6] { 
                oxygen,
                iron,
                gold,
                new Element("Hydrogen", 1, "non-metal", 13.99, 20.271),
                new Element("Bromine", 35, "non-metal", 265.8, 322.0),
                new Element("Mercury", 80, "metal", 234.3210, 629.88)
            };

            // print all elements in the array
            Console.WriteLine("\nListing all elements in the array:");
            foreach (Element element in elements)
            {
                element.Print();
            }

            // print all metals in the array (names only
            Console.WriteLine("\nThese elements are metals");
            foreach (Element element in elements)
            {
                if (element.category == "metal")
                {
                    Console.WriteLine($" * {element.name}");
                }
            }

            // print elements having a melting point below 273.16 K and a boiling point above 273.16 K
            Console.WriteLine("\nElements having a melting point (mp) below 273.16 K and a boiling point (bp) above 273.16 K");
            foreach (Element element in elements)
            {
                if( element.meltingPoint < 273.16 && element.boilingPoint > 273.16)
                {
                    Console.WriteLine($" * {element.name}, (mp: {element.meltingPoint} K, bp: {element.boilingPoint} K)");
                }
            }

            Console.ReadKey();

            
        }
    }
}