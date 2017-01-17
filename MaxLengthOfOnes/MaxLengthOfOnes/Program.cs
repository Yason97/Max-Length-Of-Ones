using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MaxLengthOfOnes
{
    class Program
    {
        static int MaxLengthOnes(string str)
        {
            int count = 0, temp = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                    temp++;
                else
                {
                    if (temp > count)
                        count = temp;
                    temp = 0;
                }
            }
            if (temp > count)
                count = temp;
            return count;
        }
        static void Main(string[] args)
        {
            StreamReader inputFile = new StreamReader("INPUT.txt");
            int result = MaxLengthOnes(inputFile.ReadLine());
            inputFile.Close();
            StreamWriter outputFile = new StreamWriter("OUTPUT.txt");
            outputFile.WriteLine(result);
            outputFile.Close();
        }
    }
}
