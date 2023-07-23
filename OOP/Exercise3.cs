using System;
namespace Day6

{
    abstract class Question
    {
        #region constructor
        public int id { get; set; }
        public static string[] body { get; set; }
        public static string[] mark { get; set; }
        #endregion

        public abstract void Show();
        #region EnterYourData
        public static void DataEntry()
        {
            System.Console.WriteLine("\n\nTeacher Input Start ******************************\n");
            System.Console.Write(" Enter Number of Question You need : ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            body = new string[number];
            mark = new string[number];

            for (int i = 0; i < number; i++)
            {
                System.Console.Write($"     Enter Question {i + 1} : ");
                body[i] = (Console.ReadLine());
                System.Console.Write($"     Enter correct answer For Question  {i + 1}  Answer is 'True / False': ");
                mark[i] = Console.ReadLine();
                System.Console.WriteLine($" \nQuestion Number {i + 1} and his Asnwer Had Entered Successfully\n");
                
            }
            System.Console.WriteLine("Teacher Input End ********************************\n\n");
        }
            #endregion

    }
    class Mcq : Question
    {
        public string[] chooses { get; set; }
       
        #region Start Answer
        public string[] StartAnswer()
        {
            System.Console.WriteLine("Student Answer Start ******************************\n");
            chooses = new string[mark.Length];
            for (int i = 0; i < mark.Length; i++)
            {
                string str = (i + 1) == 1? "st" : (i + 1) == 2 ? "nd" : (i + 1) == 3? "rd":"th";
                System.Console.WriteLine($"The {i+ 1}{str} Question is : ");
                System.Console.WriteLine($"     {body[i]}");
                System.Console.Write("     Please Enter Your Answer True Or False :  ");
                chooses[i] = Console.ReadLine();
                System.Console.WriteLine();

            }
            System.Console.WriteLine("\nStudent Answer End ********************************\n\n");
            return chooses;

        }
        #endregion
        #region showUserAnwer
        public override void Show()
        {
            // to show question with answer...
            System.Console.WriteLine("Start Showing Student Answer *************************\n");
            for (int i = 0; i < mark.Length; i++)
            {
                string str = (i + 1) == 1? "st" : (i + 1) == 2 ? "nd" : (i + 1) == 3? "rd":"th";
                System.Console.WriteLine($"The {i+ 1}{str} Question is : ");
                System.Console.WriteLine($"     {body[i]}");
                System.Console.WriteLine($"     User Answer is {chooses[i]}");
            }
            System.Console.WriteLine("End Showing Student Answer *************************\n\n");
        }
        #endregion
        

    }
    class TOrF: Question
    {
        public string[] userAnswerArray {set; get;}
        #region start
        public TOrF(string[] userAnswerArray)
        {
            this.userAnswerArray = userAnswerArray;
        }
        public TOrF(){}
        #endregion
        #region show
        public override void Show(){
            double finalResult = 0;
            
            for (int i = 0; i < mark.Length; i++)
            {
                System.Console.WriteLine($"Question Number {i + 1} is ");
                System.Console.WriteLine($"     {body[i]}");
                System.Console.WriteLine($"         Teacher Answer is : {mark[i]}");
                System.Console.WriteLine($"         Student Answer is : {userAnswerArray[i]}");
                if (mark[i].ToLower().Equals(userAnswerArray[i].ToLower()))
                {
                    System.Console.WriteLine("Wow! Student Answer  Is Correct\n");
                    finalResult ++;
                }
                else {
                    System.Console.WriteLine("OOP! Student Answer is Not Correct\n");
                }
            }
            finalResult = ( finalResult / (double)mark.Length ) * 100;

            System.Console.WriteLine($"Final Result for User is : {finalResult}%" );


        }
        #endregion

    }

    class Day6
    {
        static void ssMain(string[] args)
        {
            Question.DataEntry();

            #region mcq
            Mcq mcq = new Mcq();
            string [] userAnswer = mcq.StartAnswer();
            mcq.Show();
            #endregion

            #region TrueOrFalse
            TOrF checkUserAnswer = new TOrF(userAnswer);
            checkUserAnswer.Show();
            #endregion


        }
    }
}

/*

Is the Earth flat?                                          False
Is the sun a planet?                                        False
Is water composed of two elements, hydrogen and oxygen?     True
Is the capital of Japan Tokyo?                              True
*/