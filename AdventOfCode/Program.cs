// See https://aka.ms/new-console-template for more information

const string filePath = "/Users/everettbryant/RiderProjects/AdventOfCode/AdventOfCode/day1_data.txt";
//const string filePathTest = "/Users/everettbryant/RiderProjects/AdventOfCode/AdventOfCode/test_data.txt";

var coordinateContainerA = new List<int>();
var coordinateContainerB = new List<int>();
var totalDistance = 0;

foreach (var line in File.ReadLines(filePath))
{
    var coordinates = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    coordinateContainerA.Add(Int32.Parse(coordinates[0]));
    coordinateContainerB.Add(Int32.Parse(coordinates[1]));
}

coordinateContainerA.Sort();
coordinateContainerB.Sort();

for (var i = 0; i < coordinateContainerA.Count; i++)
{
    var distance = FindDistanceBetweenCoordinates(coordinateContainerA[i], coordinateContainerB[i]);
    totalDistance += distance;
    Console.WriteLine(distance);
}

Console.WriteLine(" ");
Console.WriteLine($"The total distance is {totalDistance}");

int FindDistanceBetweenCoordinates(int a, int b)
{
    if (a > b)
    {
        return a - b;
    }
    else
    {
        return b - a;
    }
}
