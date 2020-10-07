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

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    class WarmUpCountingValleys
    {
        static void WarmUp(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = WarmUpCountingValleys.countingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

           /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

        public static int countingValleys(int steps, string path)
        {
            // return value for the count of the valleys
            int valleys = 0;

            // A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.

            // Need to keep track how far we've gone down and up to determine if we've finished exiting 
            int stepsDown = 0;
            int stepsUp = 0;

            // Start analyzing the steps. We count a valley when we go from a D to a U
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'D')
                {
                    stepsDown++;
                }
                if (path[i] == 'U')
                {
                    stepsUp++;
                }
                // We've taken an equal number and the last was an up - we're at sea level.
                if (stepsDown == stepsUp && path[i] == 'U')
                {
                    // Increment valleys and clear the step counts
                    valleys++;
                    stepsDown = 0;
                    stepsUp = 0;
                }
            }

            return valleys;
        }
    }
}
