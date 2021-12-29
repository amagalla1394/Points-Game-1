using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scores
{
    class Program
    {
        
        //find way to pull data from bank
        static int highscore = 18;
        static string highscorePlayer = "CompAI";

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the random guessing game! Try to beat the computer score.\n" +
                              "Currently, the highscore is 18.\n");

            Console.WriteLine("The rules are simple... You'll get an attemp at guessing five numbers.");
            Console.WriteLine("The number in each field will be between 0 and 9.");
            Console.WriteLine("Guess correctly for '5' points\n" +
                              "Guess within the touching number above or below for '4' points\n" +
                              "Guess the second furthest number above or below for '3' points\n" +
                              "Guess the third furthest number above or below for '2' points\n" +
                              "Guess the fourth furthest number above or below for '1' point\n" +
                              "Any other guess outside of the scope will provide '0' points\n");

            Console.WriteLine("Player, state your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("\nAlright, welcome to the game " + playerName + ". We hope you are ready.\n");
                       

            int firstResponse = Question1();
            int secondResponse = Question2();
            int thirdResponse = Question3();
            int fourthResponse = Question4();
            int fifthResponse = Question5();

            int finalSum = firstResponse + secondResponse + thirdResponse + fourthResponse + fifthResponse;
            Console.WriteLine("\nYour total score was " + finalSum);
            if (finalSum <= highscore)
            {
                Console.WriteLine("\nSorry " + playerName + ", the highscore is still held by " + highscorePlayer + "\n");
            }else if (finalSum > highscore)
            {
                Console.WriteLine("\nCongratulations " + playerName + "!!! You beat the high score.\n");
            }

            Console.WriteLine("List of Winners: \n" +
                              "1st Place........................CompAI              21pts\n" +
                              "2nd Place........................CompAI              20pts\n" +
                              "3rd Place........................CompAI              19pts\n" +
                              "4th Place........................CompAI              18pts\n" +
                              "5th Place........................CompAI              18pts\n");
            
        }

        static private int Question1()
        {
            int firstNumOne;
            int firstNum1 = 4;
            Console.WriteLine("Enter your first guess: ");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYou guessed " + firstNum + ", The first number was 4.");
            if(firstNum == firstNum1)
            {
                Console.WriteLine("Congrats! you have earned 5 points!");
                firstNumOne = 5;

            }else if (firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Great Job! you have earned 4 points!");
                firstNumOne = 4;

            }else if (firstNum == 2 || firstNum == 6)
            {
                Console.WriteLine("Good Job! you have earned 3 points!");
                firstNumOne = 3;

            }else if (firstNum == 1 || firstNum == 7)
            {
                Console.WriteLine("Nice, you have earned 2 pointss");
                firstNumOne = 2;

            }else if (firstNum == 0 || firstNum == 8)
            {
                Console.WriteLine("You have earned 1 point");
                firstNumOne = 1;
            }else
            {
                Console.WriteLine("Your guess was outside of the range, 0 points.");
                firstNumOne = 0;                
            }
            return firstNumOne;
        }

        static private int Question2()
        {
            int firstNumTwo;
            int secondNum1 = 9;
            Console.WriteLine("\nEnter your second guess: ");
            int secondNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYou guessed " + secondNum + ", The second number was 9.");
            if (secondNum == secondNum1)
            {
                Console.WriteLine("Congrats! you have earned 5 points!");
                firstNumTwo = 5;

            }
            else if (secondNum == 8)
            {
                Console.WriteLine("Great Job! you have earned 4 points!");
                firstNumTwo = 4;

            }
            else if (secondNum == 7)
            {
                Console.WriteLine("Good Job! you have earned 3 points!");
                firstNumTwo = 3;

            }
            else if (secondNum == 6)
            {
                Console.WriteLine("Nice, you have earned 2 pointss");
                firstNumTwo = 2;

            }
            else if (secondNum == 5)
            {
                Console.WriteLine("You have earned 1 point");
                firstNumTwo = 1;
            }
            else
            {
                Console.WriteLine("Your guess was outside of the range, 0 points.");
                firstNumTwo = 0;
            }
            return firstNumTwo;
        }

        static private int Question3()
        {
            int firstNumThree;
            int thirdNum1 = 0;
            Console.WriteLine("\nEnter your third guess: ");
            int thirdNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYou guessed " + thirdNum + ", The third number was 0.");
            if (thirdNum == thirdNum1)
            {
                Console.WriteLine("Congrats! you have earned 5 points!");
                firstNumThree = 5;

            }
            else if (thirdNum == 1)
            {
                Console.WriteLine("Great Job! you have earned 4 points!");
                firstNumThree = 4;

            }
            else if (thirdNum == 2)
            {
                Console.WriteLine("Good Job! you have earned 3 points!");
                firstNumThree = 3;

            }
            else if (thirdNum == 3)
            {
                Console.WriteLine("Nice, you have earned 2 pointss");
                firstNumThree = 2;

            }
            else if (thirdNum == 4)
            {
                Console.WriteLine("You have earned 1 point");
                firstNumThree = 1;
            }
            else
            {
                Console.WriteLine("Your guess was outside of the range, 0 points.");
                firstNumThree = 0;
            }
            return firstNumThree;
        }

        static private int Question4()
        {
            int firstNumFour;
            int fouthNum1 = 6;
            Console.WriteLine("\nEnter your fourth guess: ");
            int fourthNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYou guessed " + fourthNum + ", The fourth number was 6.");
            if (fourthNum == fouthNum1)
            {
                Console.WriteLine("Congrats! you have earned 5 points!");
                firstNumFour = 5;

            }
            else if (fourthNum == 5 || fourthNum == 7)
            {
                Console.WriteLine("Great Job! you have earned 4 points!");
                firstNumFour = 4;

            }
            else if (fourthNum == 4 || fourthNum == 8)
            {
                Console.WriteLine("Good Job! you have earned 3 points!");
                firstNumFour = 3;

            }
            else if (fourthNum == 3 || fourthNum == 9)
            {
                Console.WriteLine("Nice, you have earned 2 pointss");
                firstNumFour = 2;

            }
            else if (fourthNum == 2)
            {
                Console.WriteLine("You have earned 1 point");
                firstNumFour = 1;
            }
            else
            {
                Console.WriteLine("Your guess was outside of the range, 0 points.");
                firstNumFour = 0;
            }
            return firstNumFour;
        }

        static private int Question5()
        {
            int firstNumFive;
            int fifthNum1 = 3;
            Console.WriteLine("\nEnter your fifth guess: ");
            int fifthNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nYou guessed " + fifthNum + ", The fifth number was 3.");
            if (fifthNum == fifthNum1)
            {
                Console.WriteLine("Congrats! you have earned 5 points!");
                firstNumFive = 5;

            }
            else if (fifthNum == 2 || fifthNum == 4)
            {
                Console.WriteLine("Great Job! you have earned 4 points!");
                firstNumFive = 4;

            }
            else if (fifthNum == 1 || fifthNum == 5)
            {
                Console.WriteLine("Good Job! you have earned 3 points!");
                firstNumFive = 3;

            }
            else if (fifthNum == 0 || fifthNum == 6)
            {
                Console.WriteLine("Nice, you have earned 2 pointss");
                firstNumFive = 2;

            }
            else if (fifthNum == 7)
            {
                Console.WriteLine("You have earned 1 point");
                firstNumFive = 1;
            }
            else
            {
                Console.WriteLine("Your guess was outside of the range, 0 points.");
                firstNumFive = 0;
            }
            return firstNumFive;
        }
    }
}
