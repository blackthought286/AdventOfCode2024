// See https://aka.ms/new-console-template for more information

const string filePath = "/Users/everettbryant/RiderProjects/AdventOfCode/AdventOfCode/day1_data.txt";
const string filePathTest = "/Users/everettbryant/RiderProjects/AdventOfCode/AdventOfCode/test_data.txt";

var coordinateContainerA = new List<int>();
var coordinateContainerB = new List<int>();
var totalSimilarScore = 0;

foreach (var line in File.ReadLines(filePath))
{
    var coordinates = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    coordinateContainerA.Add(Int32.Parse(coordinates[0]));
    coordinateContainerB.Add(Int32.Parse(coordinates[1]));
}

coordinateContainerA.Sort();
coordinateContainerB.Sort();

foreach (var i in coordinateContainerA)
{
    var similar = coordinateContainerB.Count(x => x == i);

    var similarScore = i * similar;
    
    Console.WriteLine(i);
    Console.WriteLine(similar);
    totalSimilarScore += similarScore;
    
}

Console.WriteLine(" ");
Console.WriteLine($"The total similiar score is: {totalSimilarScore}");