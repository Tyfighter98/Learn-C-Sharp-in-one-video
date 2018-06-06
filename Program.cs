using System;
using System.Collections.Generic;
using System.Text;

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

        static void advancedStringOperations() {
            // String builders are for editing a string without creating another string
            StringBuilder sb = new StringBuilder();

            // Adds on whatever is passed in to the string builer object
            sb.Append("This is the first sentence. ");
            // Use AppendFormat if you need to format in anything to the string
            sb.AppendFormat("My name is {0} and I live in {1}", "Tyler", "San Diego");

            // replaces all occurences of "a" with "e"
            sb.Replace("a", "e");
            // Removes the characters in index 5-7
            sb.Remove(5, 7);
            
            // If we want to print a string builder object we need to user ToString()
            Console.WriteLine(sb.ToString());
        }

        static void basicArrayOperations() {
            int[] randNumArray;

            int[] randArray = new int[5];

            int[] randNumArray2 = {1, 2, 3, 4, 5};

            Console.WriteLine("Array length: " + randNumArray2.Length);
            Console.WriteLine("Item 0: {0}", randNumArray2[0]);

            for (int i = 0; i < randNumArray2.Length; i++) {
                Console.WriteLine("{0} @ {1}", i, randNumArray2[i]);
            }

            // foreach can be used as a simplified for statement
            foreach(int num in randNumArray2) {
                Console.WriteLine(num);
            }

            // IndexOf will find the if and where the passed in number exists in the passed in array object
            Console.WriteLine("Where is 1: {0}", Array.IndexOf(randNumArray2, 1));

            string[] names = {"Tom", "Paul", "Sally"};

            // Join will put all three names together into one string will ", " seperating each of the objects
            string nameStr = string.Join(", ", names);
            Console.WriteLine(nameStr);

            // We can split objects from a string into indexes of an array with Split()
            // New idexes will be created at each occurence of the passed in value
            // In this case ", "
            string[] nameArray = nameStr.Split(", ");

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(nameArray[i]);
            }

            // Notice for multi-dimentsional arrays we add "," inside the brackets
            int[,] multArray = new int[5, 3];
            int[,] multArray2 = {{0, 1}, {2, 3}, {4, 5}};

            // If you just need to print each item of a 2D array this is probably the easies way
            foreach(int num in multArray2) {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++) {
                for (int y = 0; y < multArray2.GetLength(1); y++) {
                    Console.WriteLine("({0}, {1}): {2}", x, y, multArray2[x, y]);
                }
            }
        }

        static void basicListOperations() {
            List<int> numList = new List<int>();
            // Will add on objects to the end of the list
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            int[] randArray = {1, 2, 3, 4, 5};
            // AddRange can be used to import whole arrays into a list
            numList.AddRange(randArray);

            // We can also copy the contents of an array at list creation by passing it in at the end
            List<int> numList2 = new List<int>(randArray);
            // Or we can create an array in the arguments at the end as well
            // probably more useful
            List<int> numList3 = new List<int>(new int[] {1, 2, 3, 4});

            // (<index>, <data>)
            numList.Insert(1, 10);
            // Removes FIRST OCCURENCE of "5" from the list
            numList.Remove(5);
            Console.WriteLine("5 was removed.");

            // Removes an object at index 2
            numList.RemoveAt(2);

            // Notice for list we use COUNT instead of length
            for (int i = 0; i < numList.Count; i++) {
                Console.WriteLine(numList[i]);
            }

            // Returns -1 if the passed in data does not exist in the list
            Console.WriteLine("4 is in index: {0}", numList3.IndexOf(4));
            Console.WriteLine("Is 5 in the list: {0}", numList.Contains(5));

            List<string> strList = new List<string>(new string[] {"Tom", "Paul"});

            Console.WriteLine("Is Tom in the list: " + strList.Contains("Tom"));
            
            // Will alphabetically sort the entire list
            strList.Sort();

            for (int i = 0; i < strList.Count; i++) {
                Console.WriteLine(strList[i]);
            }

            // Will delete all items inside the calling list
            numList.Clear();
        }

        static void basicExceptionHandeling() {
            try {
                Console.Write("Divide 10 by : ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));
            }
            // This will catch a specific exception and store it in ex
            catch (DivideByZeroException ex){
                Console.WriteLine("You can't by zero.");
                // Gets the name of the exception
                Console.WriteLine(ex.GetType().Name);
                // Retruns a message describing the exception
                Console.WriteLine(ex.Message);
                
                // You can throw additional exceptions too
                throw new InvalidOperationException("Operation Failed", ex);
            }
            // Catches all other exceptions
            catch(Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }

        static void makeAnimal() {
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            // Notice we need to use Animal since numOfAnimals is owned by Animal not spot
            Console.WriteLine("Number of Animals: {0}", Animal.getNumOfAnimals());

            Console.WriteLine(spot.print());

            Console.WriteLine(spot.getSum(1.4, 2.7));
            
            // Create an Animal object using the object initalizer
            Animal grover = new Animal {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrrr"
            };

            Dog spike = new Dog();
            Console.WriteLine(spike.print());

            spike = new Dog(10, 15, "Spike", "Grrr", "Chicken");
            Console.WriteLine(spike.print());
        }

        static void makeShapes() {
            Shape rect = new Rectangle(5,5);
            Shape tri = new Triangle(5,5);

            Console.WriteLine("Rect Area: {0}", rect.area());
            Console.WriteLine("Tri Area: {0}", tri.area());

            // Uses operator overflow for "+"
            Rectangle combRect = new Rectangle(5,5) + new Rectangle(5,5);
            
            Console.WriteLine("Combined Rect Area: {0}", combRect.area());
        }

        static void makeGeneric() {
            // the two data types passed in will be used for TKey and TValue in the generic declaration
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");
            samsungTV.key = 12345;
            samsungTV.value = "a 50 inch Samsung TV";

            superman.showData();
            samsungTV.showData();
        }
    }

    class Animal {
        // This is a shorthand that automatically creates getters and setters for a variable
        public double height {get; set;}
        public double weight {get; set;}
        public string sound {get; set;}

        public string name;
        // Mannuel declaration of getters adn setters
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        // Default value constructor
        public Animal() {
            this.height = 0;
            this.weight = 0;
            this.sound = "No sound";
            this.name = "No name";

            numOfAnimals++;
        }

        // Explicit value constructor
        public Animal(double height, double weight, string name, string sound) {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            
            numOfAnimals++;
        }

        // This is a static field
        // We use it since it doesn't make sense for the animal to know how many animlas exist
        // static members can't access class members (height, weight, etc...)
        static int numOfAnimals = 0;
        
        public static int getNumOfAnimals() {
            return numOfAnimals;
        }

        public string print() {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height,
            weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1) {
            return num1 + num2;
        }

        // Overloads the int version of getSum
        public double getSum(double num1 = 1, double num2 = 1) {
            return num1 + num2;
        }
    }

    // ":" signifies that there is an inherited class
    class Dog : Animal {
        public string favFood {get; set;}

        // base() will call the parent's constructor
        public Dog() : base() {
            this.favFood = "No Favorite Food";
        }

        // For the explict value constructor make sure to put the variables from the parent class in the
        // arguments of base()
        public Dog(double height, double weight, string name, string sound, string favFood)
        : base(height, weight, name, sound) {
            this.favFood = favFood;
        }

        // To override a parent function just put "new" in front of it
        new public string print() {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}",
            name, height, weight, sound, favFood);
        }
    }

    // Abstract class sets up a template for the children to follow and fill out
    // one or more of the mehtods is left uncompleted and declared abstract
    // If all methods in an abstract class are declared as abstract, it is the same as an interface
    abstract class Shape {
        public abstract double area();

        // This method could not be in an interface which is why we would need an abstract class
        public void sayHi() {
            Console.WriteLine("Hello");
        }
    }

    // Interfaces provide a set of methods without implementation that must be overridden by the child class
    // The benifit of interfaces over abstract classes is it allows for a class to be a part of two classes
    // One class being inherited and the other coming from ther interface
    public interface ShapeItem {
        // all methods inside an interface are abstract so we don't need to put abstract up front
        double area();
    }

    class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double num1, double num2) {
            length = num1;
            width = num2;
        }

        // We need override in order to override the method inhereted from the parent
        public override double area()
        {
            return length * width;
        }

        // operator overloading function should be declared as static
        // to overload an operator, just put "operator<operator to overload>"
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2) {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape {
        private double height, triangleBase;

        public Triangle(double num1, double num2) {
            triangleBase = num1;
            height = num2;
        }

        public override double area()
        {
            return 0.5 * (triangleBase * height);
        }
    }

    // This is a generic
    // generics allow us to write methods without including the variable type
    // TKey and TValue are the "variable types" and can be defined when they are run
    class KeyValue<TKey, TValue> {
        public TKey key {get; set;}
        public TValue value {get; set;}

        public KeyValue(TKey k, TValue v) {
            key = k;
            value = v;
        }

        public void showData() {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }

    // Enums have a unique type with symbolic name and associated values
    public enum Temperature {
        // The default is the first item is set to 0, the second 1, etc...
        // You can override this if you want
        Freeze,
        Low,
        Warm,
        Boil
    }
}