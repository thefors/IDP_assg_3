namespace Elements
{
    internal class Program
    {
        
        public class Element
        {
            public string name;
            public int Z;
            public string category;
            public int meltingPoint;
            public int boilingPoint;

            public Element(string name, int z, string category, int meltingPoint, int boilingPoint)
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
            Console.WriteLine("Welcome to Elements");
            Console.WriteLine("===================\n");
        }
    }
}