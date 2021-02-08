// HackerRank Easy Challenge by Shafaet
// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem


using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int numOfJumps = 0;
        int iterator = 0;
        while (iterator < c.Length)
        {
            if (iterator + 2 < c.Length)
            {
                if (c[iterator + 2] == 0)
                {
                    numOfJumps++;
                    iterator += 2;
                }
                else 
                {
                    numOfJumps++;
                    iterator++;
                }
            }
            else if (iterator + 1 < c.Length)
            {
                numOfJumps++;
                iterator++;
            }
            else
            {
                break;
            }
        };
        return numOfJumps;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
