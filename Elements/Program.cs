namespace Elements
{
    internal class Program
    {
        
        public class Element
        {
            public string name;
            public int Z;
            public string category;
            public double meltingPoint;
            public double boilingPoint;

            public Element(string name, int z, string category, double meltingPoint, double boilingPoint)
            {
                this.name = name;
                this.Z = z;
                this.category = category;
                this.meltingPoint = meltingPoint;
                this.boilingPoint = boilingPoint;
            }
        }
        static void Main(string[] args)
        {
            // welcome
            Console.WriteLine("Welcome to Elements");
            Console.WriteLine("===================\n");

            // three instances: oxygen, iron and gold
            Element oxygen = new Element("oxygen", 8, "non-metal", 54.36, 90.188);
            Element iron = new Element("iron", 26, "metal", 1811, 3134);
            Element gold = new Element("gold", 79, "metal", 1337.33, 3243);
            
        }
    }
}