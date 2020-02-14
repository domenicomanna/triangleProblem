using System;
using System.Collections.Generic;
using System.IO;

namespace triangleProblem
{
    public class TriangleFileReader
    {

        /// <returns> a list with each entry representing a row of the triangle </returns>
        public static List<int[]> ReadFile(string filePath)
        {
            List<int[]> triangleRows = new List<int[]>();
            StreamReader streamReader = new StreamReader(filePath);
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                line = line.Trim();
                string[] characters = line.Split(' ');
                int[] integers = ConvertToIntArray(characters);
                triangleRows.Add(integers);
            }

            return triangleRows;
        }

        private static int[] ConvertToIntArray(string[] characters)
        {
            int[] integers = new int[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                integers[i] = Convert.ToInt32(characters[i]);
            }
            return integers;
        }
    }
}