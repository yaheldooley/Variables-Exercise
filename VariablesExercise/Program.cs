namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Timmy";
            int age = 14;
            char thisChar = '@';
            bool hasTimmyFallenDownAWell = true;
            double treasureValue = 18000000;
            decimal afterTaxValue = 900m;

            name = (name == null || name == "") ? "unknown" : name;

            Console.WriteLine($"A {age} year old kid named {name}, fell down a well, but survived!\n");
            Console.WriteLine($"Luckily he landed on a pile of cushy gold coins and other pirate's booty worth ${treasureValue}.\n");
            Console.WriteLine($"Well...${afterTaxValue} after taxes anyway...");
        }
    }
}