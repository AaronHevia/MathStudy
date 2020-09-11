using System;

namespace MathStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 150;
                        
            // Header
            ///<summary>
            ///Application header, also sets the console title
            ///</summary>
            ///<param name="title">Title of application</param>
            ///<param name="subtitle">Subtitle of application</param>
            ///<param name="foreGroundColor">Foreground color</param>
            static void Header(string title = "", string subtitle = "", ConsoleColor foreGroundColor = ConsoleColor.DarkCyan, int windowWidthSize = 150)
            {
                Console.Title = title + (subtitle != "" ? " - " + subtitle : "");
                string titleContent = CenterText(title, "║");
                string subtitleContent = CenterText(subtitle, "║");
                string borderLine = new String('═', windowWidthSize - 2);

                Console.ForegroundColor = foreGroundColor;
                Console.WriteLine($"╔{borderLine}╗");
                Console.WriteLine(titleContent);
                if (!string.IsNullOrEmpty(subtitle))
                {
                    Console.WriteLine(subtitleContent);
                }
                Console.WriteLine($"╚{borderLine}╝");
                Console.ResetColor();
            }

            /// <summary>
            /// Align content to center for console. Can be used with decoration if used inside menu or header
            /// </summary>
            /// <param name="content">Content to center</param>
            /// <param name="decorationString">Left and right decoration, default is empty/none</param>
            /// <returns>Center aligned text</returns>
            static string CenterText(string content = "", string decorationString = "", int windowWidthSize = 150)
            {
                int windowWidth = windowWidthSize - (2 * decorationString.Length);
                return String.Format(decorationString + "{0," + ((windowWidth / 2) + (content.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (content.Length / 2) + decorationString.Length) + "}", content, decorationString);
            }
            Header("MATH TUTOR", "FOR AIDEN AND ARIANNA");

            //  Log In
            /// <summary>
            /// Input username to determine which calculator to run or close the program if it is not the correct user.
            ///  </summary>                        
            string username;
            {
            Start2:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nHello and welcome to Math Tutor.  I am your tutor assigned by your dad.  You can call me BOT.  What is your name?  ");
                username = Console.ReadLine().ToLower();
                if (username == "aiden")
                    goto Start;
                else if (username == "arianna")
                    goto Start1;
                else Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("\nIncorrect User.  Please enter a correct username, or close the program to end.");                
                    goto Start2;
            }
            //Calculator1 (Multiplication Calculator (0-100)
            Start:
            Start3:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHello Aiden.  Today we will be studying our multiplication math.     <PRESS SPACE TO CONTINUE.>");
            Console.ReadKey();
            Console.WriteLine("\nI will be giving you two numbers to multiply and you will give me the answer.     <PRESS SPACE TO CONTINUE.>");
            Console.ReadKey();
            Console.Write("\nDo you understand what you need to do?     <PRESS (Y) FOR YES AND (N) FOR NO.>");
            string answer1;
            bool response1 = false;
            answer1 = Console.ReadLine().ToLower();
            if (answer1 == "n")
            {
                response1 = false;
            }
            else if (answer1 == "y")
            {
                response1 = true;
            }
            if (response1 == false)
            {
                goto Start3;
            }
            if (response1 == true)
            {
                goto Start4;
            }            
            
            Start4:
            Start5:
            Start6:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Random NumberGenerator = new Random();
            int num01 = NumberGenerator.Next(0, 101);
            int num02 = NumberGenerator.Next(0, 101);
            int Index1 = NumberGenerator.Next(1, 4);
            switch(Index1)
            {
                case 1:
                    Console.Write("\nMultiply " + num01 + " and " + num02 + ".");
                    break;
                case 2:
                    Console.Write("\nWhat is the product of " + num01 + " and " + num02 + ".");
                    break;
                case 3:
                    Console.Write("\nWhat is " + num01 + " times " + num02 + "?");
                    break;
            }                        
            int solution1 = Convert.ToInt32(Console.ReadLine());
            if (solution1 == num01 * num02)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int correctIndex1 = NumberGenerator.Next(1, 7);
                switch (correctIndex1)
                {
                    case 1:
                        Console.WriteLine("\nGreat!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nAwesome!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nGood job!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nGreat effort!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\nAwesome Sauce!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\nSuch a smarty pants!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                }
                goto Start5;
            }
            else if (solution1 != num01 * num02)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                int incorrectIndex1 = NumberGenerator.Next(1, 4);
                switch (incorrectIndex1)
                {
                    case 1:
                        Console.WriteLine("\nNah nah nah nah Boo Boo...Try Again!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nSeriously??? Give it your best shot.\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nWhat!!!! You don't know that?  Try again.\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                }
                goto Start6;
            }

            //Calculator2 (Addition Calculator (0-10) 
            Start1:
            Start7:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nHello Arianna.  Today we will be studying our addition math.     <PRESS SPACE TO CONTINUE.>");
            Console.ReadKey();
            Console.WriteLine("\nI will be giving you two numbers to add and you will give me the answer.     <PRESS SPACE TO CONTINUE.>");
            Console.ReadKey();
            Console.WriteLine("\nThe goal is to add without using fingers.     <PRESS SPACE TO CONTINUE.>");
            Console.ReadKey();
            Console.Write("\nDo you understand what you need to do?     <PRESS (Y) FOR YES AND (N) FOR NO.>");
            string answer2;
            bool response2 = false;
            answer2 = Console.ReadLine().ToLower();
            if (answer2 == "n")
            {
                response2 = false;
            }
            else if (answer2 == "y")
            {
                response2 = true;
            }
            if (response2 == false)
            {
                goto Start7;
            }
            if (response2 == true)
            {
                goto Start8;
            }

            Start8:
            Start9:
            Start10:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random numberGenerator = new Random();
            int num03 = numberGenerator.Next(0, 11);
            int num04 = numberGenerator.Next(0, 11);
            Console.WriteLine("\nQue es " + num03 + " mas " + num04 + " ?");
            int solution2 = Convert.ToInt32(Console.ReadLine());
            if (solution2 == num03 + num04)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int correctIndex2 = numberGenerator.Next(1, 7);
                switch (correctIndex2)
                {
                    case 1:
                        Console.WriteLine("\n¡Eres lista!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n¡Muy bien!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n¡Siguelo!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n¡Asi!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\n¡Claro que si!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\nSuch a smarty pants!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                }
                goto Start9;
            }
            else if (solution2 != num03 + num04)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                int incorrectIndex2 = numberGenerator.Next(1, 5);
                switch (incorrectIndex2)
                {
                    case 1:
                        Console.WriteLine("\nNah nah nah nah Boo Boo...Try Again!!\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nSeriously??? Give it your best shot.\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nWhat!!!! You don't know that?  Try again.\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nDon't use your fingers or mommy will chop them off!!! Try again.\t\t\t<PRESS SPACE TO CONTINUE.>");
                        Console.ReadKey();
                        break;
                }
                goto Start10;
            }

            //Scoring Calculator (after looping for x amount of times)
            //Switch User
            //Exit Options
            //Sound Effects

            Console.Read();
        }
        
        
    }
}
