using System;

namespace BasicAlgorithm
{
    class Algorithm
    {
        public Algorithm()
        {
        
        }
        public void ComputeSum()
        {
            System.Console.Write("Row Number : ");
            int row = int.Parse(Console.ReadLine());
         

            for (int i = 0; i < row; i++)
            {
                System.Console.Write("Enter First Row : x, y : ");
                string[] part = Console.ReadLine().Split(",");

                int a = int.Parse(part[0]);
                int b = int.Parse(part[1]);

                int result = a == b? (a + b) * 3: (a + b);
                System.Console.WriteLine(result);

            }

        }
        public void RemoveAtGivenPosition()
        {
            System.Console.Write("Enter String: ");
            string s = Console.ReadLine();
            System.Console.Write("Enter the Positon: ");
            int pos = int.Parse(Console.ReadLine());

            if (pos >= 0 && pos < s.Length)
            {
                string str = s.Substring(0, pos) + s.Substring(pos + 1);
                System.Console.WriteLine(str);

            }
            else {
                System.Console.WriteLine("Invalid Enter ");
            }
        }
        #region startwithC#
        public void StartWithCSharp (string str) {
            if (str.Substring(0,2).ToUpper().Equals("C#"))
            {
                System.Console.WriteLine(true);
            }
            else
                System.Console.WriteLine(false);
        }
        #endregion
    
        #region IsInRange
        public void IsInRange()
        {
            int[,]  arr = new int[3,3];
            int j = -1;
            bool check = false;


            for (int i = 0; i < 3; i++)
            {
                j += 1;
                string[] curr = Console.ReadLine().Split(",");
                int k = 0;
                foreach (string item in curr)
                {
                    arr[j, k] = int.Parse(item);
                    k += 1;
                }
            }
            for (int i = 0; i < 3; i ++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if ((arr[i,l] >= 20 && arr[i, l] <= 50))
                    {
                        check = true;
                    }
                }
                System.Console.WriteLine(check);
                check = false;
            }
        }
        #endregion
    }

    class BasicAlgorithm
    {
        public static void Main(string[] args)
        {
            Algorithm algo = new Algorithm();
            algo.IsInRange();
            // algo.StartWithCSharp("s#");

        
            // algo.RemoveAtGivenPosition();
            // stop at ten
        }
    }
}
