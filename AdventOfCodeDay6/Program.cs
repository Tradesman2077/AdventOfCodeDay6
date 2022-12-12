var input = System.IO.File.ReadAllText(@"C:\Users\chris\source\repos\AdventOfCodeDay6\AdventOfCodeDay6\TextFile1.txt");
List<string> output = new List<string>();

//for (int i = 0; i < input.Length; i++)
//{
//    if (i < 4)
//    {
//        output.Add(input[i].ToString());
//    }
//    output.RemoveAt(0);
//    output.Add(input[i].ToString());
//    if (output.Distinct().Count() == output.Count() && output.Count() == 4)
//    {
//        Console.WriteLine(i+1);
//        break;
//    }
//}
for (int i = 0; i < input.Length; i++)
{
    if (i < 14)
    {
        output.Add(input[i].ToString());
    }
    output.RemoveAt(0);
    output.Add(input[i].ToString());
    if (output.Distinct().Count() == output.Count() && output.Count() == 14)
    {
        Console.WriteLine(i + 1);
        break;
    }
}