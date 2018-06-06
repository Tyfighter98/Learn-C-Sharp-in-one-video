using System;

namespace learn_c_
{
    class Program
    {
        // Run with "dotnet run"
        static void Main(string[] args)
        {
            
        }

        // Teaches basic console output and input
        static void outputInput() {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
        }

        static void variableTypes() {
            bool canVote = true;
            char grade = 'A';
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDec = decimal.MaxValue;
            // 7 decimals of precison
            float maxFloat = float.MaxValue;
            // 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);
        
            // Var is defined at compile time
            // This defines var as a string in this case
            var anotherName = "Warren";

            // Like in python we can use braces to signify that a varaible will be put in
            // We can put the varaible with a comma after the quotes
            // Notice that we need to put a number in the braces to signify which argument it is
            Console.WriteLine("Last name: {0}", anotherName);
            Console.WriteLine("var is of type: {0}", anotherName.GetTypeCode());
        }

        static void basicMath() {
            Console.WriteLine("5.3 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i += 3" + (i += 3));
            // By putting the pluses after the i, the current value will be printed AND THEN i will be incremented
            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("i = {0}", i);
            // By putting the pluses before the i, i will be incremented and then printed (how you would think it would work)
            Console.WriteLine("++i = " + (++i));
        }

        static void basicCasting() {
            double pi = 3.14;
            // Cast pi as an int
            int intPi = (int)pi;
            Console.WriteLine("Pi = {0}", pi);
            Console.WriteLine("Pi ~ {0}", intPi);
        }

        static void advancedMath() {
            double num0 = -10.5;
            double num1 = 10.5;
            double num2 = 15;

            Console.WriteLine("Absolute Value |{0}| = {1}", num0, Math.Abs(num0));
            // rounds up to next whole number
            Console.WriteLine("Ceiling of {0} = {1}", num1, Math.Ceiling(num1));
            // rounds down to previous whole number
            Console.WriteLine("Floor of {0} = {1}", num1, Math.Floor(num1));
            // Outputs which of the two is larger
            Console.WriteLine("Max of {0} and {1} = {2}", num1, num2, Math.Max(num1, num2));
            // Outputs which of the two is smaller
            Console.WriteLine("Min of {0} and {1} = {2}", num1, num2, Math.Min(num1, num2));
            // Exponential with the second argument being the power
            Console.WriteLine("{0}^2 = {1}", num1, Math.Pow(num1, 2));
            Console.WriteLine("{0} ~ {1}", num1, Math.Round(num1));
            // Square root the passed in value
            Console.WriteLine("{0}^(1/2) = {1}", num1, Math.Sqrt(num1));
        }

        static void basicProbabilitiy() {
            // Creates a variable to interface with Random
            // Creates a new time-base seed upon creation
            Random rand = new Random();
            // Generates a random number between 1 and 10
            // Notice that 11 is NOT INCLUDED
            Console.WriteLine("Random number between 1 and 10: {0}", rand.Next(1,11));
        }

        static void basicLogicOperations() {
            int age = 17;

            if ((age >= 5) && (age <= 7)) {
                Console.WriteLine("Go to elementary school.");
            }
            else if ((age > 7) && (age < 13)) {
                Console.WriteLine("Go to elementary school.");
            }
            else {
                Console.WriteLine("Go to high school.");
            }

            if ((age < 14) || (age > 67)) {
                Console.WriteLine("Go retire or something!");
            }

            // ^ is xor
            if ((age == 17) ^ (age < 17)) {
                Console.WriteLine("You are {0} years old.", age);
                Console.WriteLine("(age = 17) xor (age <= 17) = True");
            }
            else{
                Console.WriteLine("(age = 17) xor (age < 17) = False");
            }

            Console.WriteLine("Not true (!true): {0}", (!true));

            // if age >= 16 is true, set canDrive to ture. Else set canDrive to false
            bool canDrive = age >= 16 ? true : false;

            switch(age) {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                // Stacked case statments for case 1 & 2
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }
        }

        static void basicLoops() {
            int i = 0;

            while(i < 10) {
                if (i == 7) {
                    i++;
                    // skip everything below and move to the next interation of loop
                    continue;
                }

                if (i == 9) {
                    // Break out of while loop
                    break;
                }

                if ((i % 2) > 0) {
                    // Print out odd numbers
                    Console.WriteLine(i);
                }
                i++;
            }

            string guess;

            do {
                Console.WriteLine("Guess a Number: ");
                guess = Console.ReadLine();
              // Notice the while loop doesn't have braces!!
            } while (!guess.Equals("15"));

            for (i = 0; i < 10; i++) {
                if ((i % 2) > 0) {
                    Console.WriteLine(i);
                }
            }

            string randStr = "\nHere are some random characters";
            foreach(char c in randStr){
                Console.WriteLine(c);
            }
        }

        static void basicStringOperations() {
            string sampleStr = "A bunch of random words";
            string emptyStr = " ";

            Console.WriteLine("Is empty: {0}", String.IsNullOrEmpty(sampleStr));
            Console.WriteLine("Is empty: {0}", String.IsNullOrWhiteSpace(emptyStr));
            Console.WriteLine("String Length: {0}", sampleStr.Length);
            // Will find if "bunch" exists in the string and if so, what index it starts at
            // Will return -1 if "bunch" does not exist in the string
            Console.WriteLine("Index of bunch: {0}", sampleStr.IndexOf("bunch"));
            // Substring will output a string from index 2-6 to extraxt "bunch"
            Console.WriteLine("2nd Word: {0}", sampleStr.Substring(2, 6));

            string sampleStr2 = " More random words ";
            
            // Notice we can't use "==" for checking string equivalence
            Console.WriteLine("Is string 1 = string 2: {0}", sampleStr.Equals(sampleStr2));
            Console.WriteLine("Starts with \"A bunch\": {0}", sampleStr.StartsWith("A bunch"));
            Console.WriteLine("Ends with \"Words\": {0}", sampleStr.EndsWith("words"));

            Console.WriteLine(sampleStr2 + "pace");
            // Trims whitespace off the front and back of string
            // You can do one or the other too
            sampleStr2 = sampleStr.Trim();
            Console.WriteLine(sampleStr2 + "pace");

            sampleStr = sampleStr.Replace("words", "characters");
            Console.WriteLine("Words was replaced with characters: "+ sampleStr);
            // Removes the characters from index 0-2
            sampleStr = sampleStr.Remove(0, 2);
            Console.WriteLine("Removed indexies 0-2: {0}", sampleStr);

            string[] names = new string[3] {"Matt", "Joe", "Paul"};

            // Combines the contents of an array together in a string
            // The first argument defines what you want inbetween each of the objects
            Console.WriteLine("Name List: {0}", String.Join(", ", names));

            // Format is {<which item you are formatting>:<formatting>}
            // c will format for currency
            // "00.00" will force the number to have two number after the decimal
            // "#.00" means leave it up to input whether there should be a 0 infront of the decimal or not
            // "0,0" will put a 0 after the first number
            string frmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(frmtStr);
        }
    }
}
