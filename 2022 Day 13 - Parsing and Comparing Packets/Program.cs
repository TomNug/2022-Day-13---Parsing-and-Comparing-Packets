
class Program
{




    public static void Main(string[] args)
    {
        string pathTest = @"C:\Users\Tom\Documents\Advent\2022 Day 13 - Parsing and Comparing Packets\2022 Day 13 - Parsing and Comparing Packets\data_test.txt";
        string pathFull = @"C:\Users\Tom\Documents\Advent\2022 Day 13 - Parsing and Comparing Packets\2022 Day 13 - Parsing and Comparing Packets\data_full.txt";

        string[] instructions = System.IO.File.ReadAllLines(pathTest);

        foreach(string instruction in instructions)
        {
            Console.WriteLine(instruction);
        }
    }
}
