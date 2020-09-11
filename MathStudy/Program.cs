using System;

namespace MathStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tMATH TUTOR IN ENGLISH AND SPANISH");
            Console.WriteLine("\t\t\t\t\t---------------------------------");

            /// <summary>
            /// Application header, also sets the console title
            /// </summary>
            /// <param name="title">Title of application</param>
            /// <param name="subtitle">Subtitle of application</param>
            /// <param name="foreGroundColor">Foreground color</param>
            static void Header(string title, string subtitle = "", ConsoleColor foreGroundColor = ConsoleColor.White, int windowWidthSize = 90)
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
            static string CenterText(string content, string decorationString = "", int windowWidthSize = 90)
            {
                int windowWidth = windowWidthSize - (2 * decorationString.Length);
                return String.Format(decorationString + "{0," + ((windowWidth / 2) + (content.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (content.Length / 2) + decorationString.Length) + "}", content, decorationString);
            }

            YourStaticClass.Header("Test", "Version 1.0");







            Console.Read(); 
            
            /*
            
            Console.Write("\nHello and welcome to Math Tutor.  I am your tutor, BOT.  What is your name?\n");

            string name = Console.ReadLine().ToLower();
            
            /*

            switch (name)
            {
                case "aiden":
                Start1:
                    Console.WriteLine("\nHello Aiden.  Today we will be studying our multiplication math.     <PRESS SPACE TO CONTINUE.>");
                    Console.ReadKey();
                    Console.WriteLine("\nI will be giving you two numbers to multiply and you will give me the answer.     <PRESS SPACE TO CONTINUE.>");
                    Console.ReadKey();
                    Console.WriteLine("\nDo you understand what you need to do?     <PRESS (Y) FOR YES AND (N) FOR NO.>");

                    string answer1;
                    bool response1 = false;
                    answer1 = Console.ReadLine().ToLower();

                    if (answer1 == "n")
                    {
                        response1 = false;
                    }
                    else if (answer1 == "y")
                    {
                        response1 = false;
                    }

                    if (response1 == false)
                    {
                        goto Start1;
                    }
                    if (response1 == true)
                    {
                        goto Start3;
                    }
                break;
                
                case "arianna":
                Start2:
                    Console.WriteLine("\nHello Arianna.  Today we will be studying our addition math.     <PRESS SPACE TO CONTINUE.>");
                    Console.ReadKey();
                    Console.WriteLine("\nI will be giving you two numbers to add and you will give me the answer.     <PRESS SPACE TO CONTINUE.>");
                    Console.ReadKey();
                    Console.WriteLine("\nThe goal is to add without using fingers.     <PRESS SPACE TO CONTINUE.>");
                    Console.ReadKey();
                    Console.WriteLine("\nDo you understand what you need to do?     <PRESS (Y) FOR YES AND (N) FOR NO.>");

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
                        goto Start2;
                    }
                    if (response2 == true)
                    {
                        goto Start6;
                    }
                    break;                
            }

        Start3:
        
            Random numberGenerator1 = new Random();
            int num1 = numberGenerator1.Next(1, 100);
            int num2 = numberGenerator1.Next(1, 100);

            Console.WriteLine("\nWhat is " + num1 + " times " + num2 + " ?");

            int solution1 = Convert.ToInt32(Console.ReadLine());

            if (solution1 == num1 * num2)
            {
                int correctIndex1 = numberGenerator1.Next(1, 7);

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
                goto Start4;
            }
            else if (solution1 != num1 * num2)
            {
                int incorrectIndex1 = numberGenerator1.Next(1, 4);

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
                goto Start5;
            }

        Start6: Start7: Start8:
            Random numberGenerator = new Random();
            int num3 = numberGenerator.Next(0, 11);
            int num4 = numberGenerator.Next(0, 10);

            Console.WriteLine("\nQue es " + num3 + " mas " + num4 + " ?");

            int solution2 = Convert.ToInt32(Console.ReadLine());

            if (solution2 == num3 + num4)
            {
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
                goto Start7;
            }
            else if (solution2 != num3 + num4)
            {
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
                goto Start8;
            }
            
            Start4:
            Start5:
                      
            Console.ReadKey();

    */
            }
        }
    }
