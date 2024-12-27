
using Alphabets;

AlphabetDictionary alphabetDictionary = new AlphabetDictionary();
alphabetDictionary.MapAlphabetsChart();

int counter = 1;
foreach (var d in alphabetDictionary.alphabets)
{
    Console.WriteLine($"{counter}. {d.Key} for {d.Value}");
    counter++;
}
