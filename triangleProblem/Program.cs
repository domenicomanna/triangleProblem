using System;
using System.Collections.Generic;

namespace triangleProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/domenicomanna/programming/csharp/triangleProblem/triangle.txt";
            List<int[]> triangleRows = TriangleFileReader.ReadFile(filePath);
            int maxSum = TriangleCalculator.CalculateMaxSum(triangleRows);
            System.Console.WriteLine(maxSum);
        }
    }
}
