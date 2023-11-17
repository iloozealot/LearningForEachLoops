

string data = "Tim,Bob,Sue,Jane";
List<string> firstNames = data.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}
