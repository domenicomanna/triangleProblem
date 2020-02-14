using System.Collections.Generic;

namespace triangleProblem
{
    public class TriangleCalculator
    {
        public static int CalculateMaxSum(List<int[]> triangleRows)
        {
            int sum = 0;
            int indexOfMax = 0;
            int firstAdjacentIndex = 0;  
            int secondAdjacentIndex = 0;

            foreach (int[] triangleRow in triangleRows)
            {
                indexOfMax = triangleRow[firstAdjacentIndex] > triangleRow[secondAdjacentIndex] ? firstAdjacentIndex : secondAdjacentIndex;
                sum += triangleRow[indexOfMax];
                // adjacent numbers can only be at the current max index or 1 greater than that
                firstAdjacentIndex = indexOfMax;
                secondAdjacentIndex = indexOfMax + 1;
            }

            return sum;
        }
    }
}