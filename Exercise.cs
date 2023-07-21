using System;
using System.Text.RegularExpressions; // to use regux
using System.Linq;
namespace exerciseBasic
{
    class ExerciseCSharpBasic 
    {
        public int num {set; get;}
        public string word {set; get;}
        public int num2 {set; get;}
        public int num3 {set; get;}
        public ExerciseCSharpBasic()
        {
            
        }
        public ExerciseCSharpBasic(int num, int num2,int num3,  string word)
        {
            this.num = num;
            this.word = word;
            this.num2 = num2;
            this.num3 = num3;
        }
        public void mul () {
            for (int i = 0; i <= 12; i++)
            {
                System.Console.WriteLine($"{num} * {i} = {num * i}");   
            }
        }
        public void print()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i  == 0 || i == 4) {
                        System.Console.Write($"{num}");
                    }
                    else 
                    {
                        System.Console.Write($"{num} ");
                    }
                    
                }
                System.Console.WriteLine();
            }
        }
        public void remove() 
        {
            string result = "";
            int iterate = 0;
            foreach (char i in word)
            {
                
                if (iterate != num)
                {
                    result += i;
                }
                iterate += 1;
            }
            System.Console.WriteLine(result);
        }
        public void change ()
        {
            char save = word[0];
        
            string result = "";
            int i = 0;

            for (i = 1; i < word.Length - 1; i++)
            {
                result += word[i];
            }
            result = word[i]+result + save;
            System.Console.WriteLine(result);
         
        }
        public void frontBack() 
        {
            System.Console.WriteLine(word[0]+word + word[0]);

        }
        public void NegativePositive() {
            // System.Console.WriteLine(num + num2);
            // System.Console.WriteLine($"{num}  {num2}");
            if (num > 0 && num2 < 0 || num < 0 && num2 > 0)
            System.Console.WriteLine(true);
            else
            System.Console.WriteLine(false);
        }
        public void ToLowerCase() {
            string NewString = "";
            foreach (char item in word)
            {
                int x = item;
                if (x >= 65 && x <= 91)
                x += 32;
                NewString += (char)x;
            }
            System.Console.WriteLine(NewString);
        }
        public void Prime500 () {
            int cnt = 0;
            int result = 0;
            int curr = 2;

            while (cnt < 500)
            {

                bool taken = true;
                for (int i = 2; i * i <= curr; i++)
                {
                    if (curr % i == 0)
                    {
                        taken = false;
                        break;
                    }
                }
                if (taken) {
                    result += curr;
                    cnt += 1;
                }
                curr += 1;
            }
            System.Console.WriteLine(result);
            // System.Console.WriteLine($"{curr} {cnt}");
        }
        public void Reverse() {
            string result = "";
            for (int i = word.Length - 1; i >= 0 ; i-- )
            {
                // System.Console.WriteLine("ds");
                result += word[i]; 
            }
            // System.Console.WriteLine("helo");
            System.Console.WriteLine(result);
        }
        public void FileSize() {
            FileInfo  file = new FileInfo("Day02.cs");
            System.Console.WriteLine($"Size of File in bytes is: {file.Length}");
        }
        public void ConvertHexToDecimal()
        {
            int decvalue = int.Parse(word, System.Globalization.NumberStyles.HexNumber);
            System.Console.WriteLine(decvalue);
        }
        public void MulOf3Or7() {
            bool check = (num % 3 == 0 )|| (num % 7 == 0);
            System.Console.WriteLine($"{check}");
        }
        public void StartWith() 
        {
            string specificWord = "Hello";
            string start = "";
            char check = ' ';
            foreach (char item in word)
            {
                if(item != check)
                start += item;
                else
                break;
            }
            if(start == specificWord)
                System.Console.WriteLine(true);
            
            else
                System.Console.WriteLine(false);
        }
        public void MaxThree() {
            int[] arr = new int[]{num, num2, num3};
            int MaxInt = num;
            foreach (int item in arr)
            {
                if (MaxInt < num)
                MaxInt = num;
            }
            System.Console.WriteLine(MaxInt);
        }
        public void Nearest20() {
            int[] nums = new int[]{num, num2, num3};
            int nearest = num;
            foreach (int item in nums)
            {
                // System.Console.WriteLine(item);
                if (Math.Abs(20 - item) < Math.Abs(20 - nearest) )
                {
                    nearest = item;
                }
                
            }
            System.Console.WriteLine(nearest);
        }
        public void RotateLeft() {
            int[] arr = {1, 2, 3, 4, 5, 6};
            int last = arr.Length - 1;

            for (int i = 0; i + i < arr.Length - 1; i++)
            {
                // to Swap.
                arr[i] ^= arr[last];
                arr[last] ^= arr[i]; 
                arr[i] ^= arr[last];
                last -= 1 ;
            }
            foreach (int item in arr)
            {
                System.Console.Write(item);
            }
            System.Console.WriteLine();
        }
        public void MiddleOfThree() 
        {
            int[] arr1 = {1, 2, 3, 4, 5};
            int[] arr2 = {6, 7, 8, 9, 10};
            int[] arr3 = {11, 12, 13, 14, 15};

            int[] result = new int[3]{arr1[arr1.Length / 2], arr2[arr2.Length / 2],
            arr3[arr3.Length / 2]};
            foreach (int item in result)
            {
                System.Console.Write($"{item} ");
            }
           System.Console.WriteLine();

        }   

        public void IsPalindrome() {
            string s = "abbadd";
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }

            if (s == reverse)
            {
                System.Console.WriteLine("String is Palindrome");
            }
            else {
                System.Console.WriteLine("String is unPalindrome");
            }
        }
        public void FindRange() {
            int[] arr = {1, 3, 4, 7, 9};
            int MinNumber = arr[0];
            int MaxNumber = arr[0];
            foreach (int item in arr)
            {
                if (item < MinNumber) MinNumber = item;
                if (item > MaxNumber) MaxNumber = item;
            }
            System.Console.WriteLine(MaxNumber - MinNumber - arr.Length);
            
        }
        public void IgnoreUpperZero() 
        {
            int[,] arr = new int[3,4] {
                {0, 2, 3, 2}, 
                {0, 6, 0, 1}, 
                {4, 0, 3, 0}};
            int ans = 0;
            for(int i = 0; i < arr.GetLength(0); i ++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0)
                        ans += arr[i,j];
                    else
                    {
                        if (arr[i - 1, j] != 0)
                            ans += arr[i, j];
                    }
                }
            }
            System.Console.WriteLine(ans);
        }
        public void SortArrayExceptFive()
        {
            int[] arr = new int[] {-5, 236, 120, 70, -5, -5, 698, 280 };
            
            int[] num = arr.Where(x => x != -5).OrderBy(x => x).ToArray();
            
            int cnt = 0;
            arr = arr.Select(x => x >= 0? num[cnt++]: -5).ToArray();
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }

        }
        public string ReverseInterParenthese(string ReversedString)
        {
            int l = ReversedString.LastIndexOf("(");
            if (l == -1)
                return ReversedString;
        
            int r = ReversedString.IndexOf(")", l);
            string x = ReverseInterParenthese(
                ReversedString.Substring(0, l) + 
                new string(ReversedString.Substring(l + 1, r -l - 1).Reverse().ToArray()) + 
                ReversedString.Substring(r +1)
            );

            return x;
        }
        public void GetFileName(string path) {

            System.Console.WriteLine(path.Split("/").Last());
        }
        public void findMinString(string s1, string s2) {
            int n1 = int.Parse(s1);
            int n2 = int.Parse(s2);
            int result = n1<n2?n1:n2;
            System.Console.WriteLine(result);

        }

        public void ReplaceChar(string s) {

            string newString = s.Replace("P", "9").Replace("O","S");
            System.Console.WriteLine(newString);
        }

        public void RemoveLastFirst(string s)
        {
            string x = "";
            for (int i = 1; i < s.Length - 1; i++)
            {
                x += s[i];
            }
            System.Console.WriteLine(x);
            string xx = s.Length > 2? s.Substring(1,s.Length -2) : s;
            System.Console.WriteLine(xx);
        }
        public void WholeNumber(int[] arr) {

            int sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }
            double average = (double) sum / arr.Length;

            if (average % 1 == 0)
                System.Console.WriteLine("Is Whole");
            else
                System.Console.WriteLine("Is Not Whole");
            
            // using built in function
            double average2 = arr.Average();
            // System.Console.WriteLine(average2);

             if (average2 % 1 == 0)
                System.Console.WriteLine("Is Whole");
            else
                System.Console.WriteLine("Is Not Whole");
        }
        public void OrderString(string str)
        {
            string str2 = new string(str.OrderBy(x => x).ToArray());
            System.Console.WriteLine(str2);
        }
        public void NthOdd(int num)
        {
            System.Console.WriteLine((num - 1) * 2 + 1);
        }
        public void Ascii(char s)
        {
            System.Console.WriteLine((int)s);
        }
        public void IsPlural(string s)
        {
            bool check = s.EndsWith("s");
            System.Console.WriteLine(check);
        }
        public void SumSquare(int[] arr)
        {
            int sum = arr.Sum( x => x * x);
            System.Console.WriteLine(sum);
        }
        public void ToConvertAll(object[] arr)
        {
            string[] result = Array.ConvertAll(arr, x => x.ToString());
            foreach (var item in result)
                System.Console.WriteLine(item.GetType());
        }

        public void RemoveAllNotLetter(string str)
        {
           string s = new string(str.Where(x => ((x >= 65 && x <= 91) || (x >= 97 && x <= 123))).ToArray()) ;
            System.Console.WriteLine(s);
        }
        public void RemoveVowels(string str)
        {
            string txt = new Regex(@"[auioeAUIOE]").Replace(str, "");
            System.Console.WriteLine(txt);
        }
        public void GetLowerIndex(string str) {

            // string nums= new string(str.Where(x =>  x > 96 && x < 124).ToArray());
            int[] arr = str.Select((x, i) => i).Where(i =>  str[i] > 96 && str[i] < 124).ToArray();
            foreach (int item in arr)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
        }

        public void GetCumulativeSum(int[] arr) {
            

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] += arr[i - 1];
            }
            foreach (int item in arr)
            {
                System.Console.Write(item + " ") ;                
            }
            System.Console.WriteLine();
        }
        public void GetDigitNumberNumber(string s)
        {
            int letter = 0;
            int digits = 0;
            foreach (char item in s)
            {
                if ((item >= 65 && item <= 91 ) || (item >= 97 && item <= 123))
                    letter += 1;
                else if (item >= 48  && item <= 57)
                    digits += 1;
            }
            System.Console.WriteLine($"Digits = {digits} Letters = {letter}");
        }
        public void ReverseBoolean( bool check)
        {
            System.Console.WriteLine(!check);
        }
        public void RemoveAllExceptInteger(object[] arr)
        {
            int [] result = arr.OfType<int>().ToArray();
            foreach (int item in result)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();

        }
        public void FindNextPrime(int num)
        {
            while (true)
            {
                bool check = true;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    System.Console.WriteLine(num);
                    break;
                }
                num += 1;
            }
        }
        public int FindSquare(int num, int start = 1)
        {
            if (start * start == num)
            {
                return start;
            }
            else if(start * start  > num)
            {
                return start - 1;
            }
            return FindSquare(num, start + 1);

        }
        public string LargestPrefix(string[] arr)
        {
            if (arr.Length == 0 || Array.IndexOf(arr, "") != -1)
                return "";
            
            string prefix = arr[0];
            int len = prefix.Length;
            int res = len + 2;
            foreach (string item in arr)
            {
                int j = 0;

                foreach(char c in item)
                {
                    if (len > j && c == prefix[j])
                    {

                        j += 1;
                    }
                    else {
                        res = Math.Min(res, j);
                        break;
                    }
                }

            }
            System.Console.WriteLine($"Max prefix is {prefix.Substring(0, res) }");
            return prefix.Substring(0, res);

        }

        public void IsValid(string str)
        {
            Stack <char> ch = new Stack <char>();
            bool check = true;
            foreach (char item in str)
            {
                if (item == '(')
                    ch.Push(')');
                else if (item == '<')
                    ch.Push('>');
                else if (item == '[')
                    ch.Push(']');
                else if (item == '{')
                    ch.Push('}');
                else
                {
                    if (ch.Pop() != item)
                    {
                        check = false;
                        // System.Console.WriteLine(ch.Pop());
                        break;
                    }    
                    
                }
            }
            if(ch.Count > 0)
                check = false;
            System.Console.WriteLine(check);
        }
        public bool EqualValueAndType(object first, object second) 
        {
            if (!first.Equals(second) || !first.GetType().Equals(second.GetType()))
            {
                return false;
            }
            return true;
        }
        public void FindE()
        {
            double lste = 2;
            double fact = 1;
            double n = 2;
            double e0;
            const double x = 1e-15;

            do
            {
                e0 = lste;
                fact *= n++;
                lste += 1.0 / fact;



            } while (lste - e0 > x);

            System.Console.WriteLine(lste);
        }
        public void SortString(string s) 
        {
            System.Console.WriteLine(s);
            s = new string(s.OrderBy(x =>x).ToArray());
            // System.Console.WriteLine(s);
            string result = "";
            int num = 0;
            foreach (char item in s)
            {
                if (item >= 48 && item <= 57)
                {
                    num += 1;
                    result += item;
                }
                else
                    break;
            }
            s = s.Substring(num);
            s += result;
            System.Console.WriteLine(s);
        }
    
    }
    class Remember {
        static void Main(string[] args)
        {
            ExerciseCSharpBasic mul = new ExerciseCSharpBasic(5,19, 21, "ab(cd(ef)gh)ij");
            mul.SortString("AAAbfed231");
            // mul.FindE();
            // System.Console.WriteLine(mul.EqualValueAndType(4, "4"));
            // System.Console.WriteLine(38 + 39 + 40 + 41 + 42);

            // mul.IsValid("<>()[]{");
            // mul.LargestPrefix(new string[] {"sacket", "Joint", "Junky", "Jet" });
            // int x = mul.FindSquare(120);
            // System.Console.WriteLine(x);
            // mul.FindNextPrime(4434);
            // mul.RemoveAllExceptInteger(new object[] { 25, "Anna", false, System.DateTime.Now, -112, -34.67 });
            // mul.ReverseBoolean(false);
            // mul.GetDigitNumberNumber("python1234");
            // mul.GetCumulativeSum(new int[] {1, 3, 4, 5, 6, 7});
            // mul.GetLowerIndex("abcdDDFSFde");

            // mul.RemoveVowels("AUIOfe");
            // mul.RemoveAllNotLetter("Hell#!@@!@**U()");

            // mul.ToConvertAll(new object[] { 25, "Anna", false, System.DateTime.Now, 112.22 });
            // mul.IsPlural("plues]");
            // mul.SumSquare(new int[]{1,2,3,4,5});
            

            // mul.WholeNumber( new int[] { 2, 4, 2, 6, 4, 8 });
            // mul.OrderString("PHP");
            // mul.NthOdd(100);
            // mul.Ascii('u');

                    
        }
    }   
}