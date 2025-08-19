using System.Text;

namespace Grades
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //GradedAssignments();
            //CalcualteGPA();
            //LargerOfTwo();
            //RollDice();
            //SubscriptionRenewal();
            //FradulentArray();
            //CommentChoas();
            //ScoreReport();
            //CoinFlip();
            //VariableScope();
            //SwitchStatements();
            //ForLoops();
            //DoWhile();
            //DataTypes();
            //CastingTypes();
            //Pallets();
            //CompositeFormatting();
            ParseStrings();
            Console.Read();
        }

        public static void GradedAssignments()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

        }

        public static void CalcualteGPA()
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"\n\nStudent: {studentName}\n");

            Console.WriteLine($"Course\t\t\t\tGrade\t\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

            Random dice = new Random();

        }

        public static void LargerOfTwo()
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine($"\n{largerValue}");

        }

        public static void RollDice()
        {
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            //roll1 = 6;
            //roll2 = 6;
            //roll3 = 5;

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }

        public static void SubscriptionRenewal()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);

            if (daysUntilExpiration <= 10)
            {
                if (daysUntilExpiration == 0)
                {
                    Console.WriteLine("Your subscription has expired.");
                }
                else if (daysUntilExpiration <= 1)
                {
                    discountPercentage += 20;
                    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%");
                }
                else if (daysUntilExpiration <= 5)
                {
                    discountPercentage += 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save {discountPercentage}%!");
                }
                else
                {
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                }
            }

        }
        public static void FradulentArray()
        {
            //flagged orders project
            string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            string[] flaggedOrders = new string[orders.Length];
            int orderIndex = 0;
            Console.WriteLine("Flagged Orders:");
            foreach (string order in orders)
            {
                if (order.StartsWith('B'))
                {
                    flaggedOrders[orderIndex] = order;
                    orderIndex++;
                }
            }

            Console.WriteLine("Flagged Orders:");
            foreach (string order in flaggedOrders)
            {
                Console.WriteLine(order);
            }
        }

        public static void CommentChoas()
        {
            // this method counts all the o's in a string
            // and prints it out in reverse.

            string message = "The quick brown fox jumps over the lazy dog.";

            char[] letters = message.ToCharArray();
            Array.Reverse(letters);

            int letterCount = 0;
            foreach (char letter in letters)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string reversedMessage = new String(letters);

            Console.WriteLine(reversedMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }

        public static void ScoreReport()
        {
            Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

            decimal studentScore;
            decimal examScore;
            decimal extraCreditScore;
            decimal pointsScore;

            int[] studentScores = new int[10];

            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
            foreach (string name in studentNames)
            {
                if (name == "Sophia")
                {
                    studentScores = sophiaScores;
                }
                else if (name == "Andrew")
                {
                    studentScores = andrewScores;
                }
                else if (name == "Emma")
                {
                    studentScores = emmaScores;
                }
                else if (name == "Logan")
                {
                    studentScores = loganScores;
                }
                else if (name == "Becky")
                {
                    studentScores = beckyScores;
                }
                else if (name == "Chris")
                {
                    studentScores = chrisScores;
                }
                else if (name == "Eric")
                {
                    studentScores = ericScores;
                }
                else if (name == "Gregor")
                {
                    studentScores = gregorScores;
                }
                else
                    continue;

                int examSum = 0;
                decimal extraCreditSum = 0;
                int currentScoreIndex = 0;
                int extraCreditAssigments = 0;

                foreach (int score in studentScores)
                {
                    currentScoreIndex++;
                    if (currentScoreIndex <= currentAssignments)
                    {
                        examSum += score;
                    }
                    else
                    {
                        extraCreditAssigments++;
                        extraCreditSum += (decimal)score / 10;
                    }
                }

                examScore = (decimal)examSum / currentAssignments;
                studentScore = (examSum + extraCreditSum) / currentAssignments;
                extraCreditScore = extraCreditSum * 10 / extraCreditAssigments;
                pointsScore = studentScore - examScore;

                string gradeLetter = @"N\A";

                if (studentScore >= 97)
                {
                    gradeLetter = "A+";
                }
                else if (studentScore >= 93)
                {
                    gradeLetter = "A";
                }
                else if (studentScore >= 90)
                {
                    gradeLetter = "A-";
                }
                else if (studentScore >= 87)
                {
                    gradeLetter = "B+";
                }
                else if (studentScore >= 83)
                {
                    gradeLetter = "B";
                }
                else if (studentScore >= 80)
                {
                    gradeLetter = "B-";
                }
                else
                {
                    gradeLetter = "F";
                }

                Console.WriteLine($"{name}:\t\t{examScore}\t\t{studentScore}\t{gradeLetter}\t{(int)extraCreditScore} ({pointsScore} pts)");
            }
            Console.WriteLine("Press the Enter key to continue");
        }

        public static void CoinFlip()
        {
            // warm-up
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine(flip == 1 ? "heads" : "tails");

            // code challenge
            string permission = "Admin|Manager";
            //string permission = "Bob";
            int level = 50;

            Console.WriteLine(
                (permission.Contains("Admin") && level > 55)
                ? "Welcome, Super Admin user."
                : (permission.Contains("Admin") && level <= 55)
                ? "Welcome, Admin user"
                : (permission.Contains("Manager") && level >= 20)
                ? "Contact an Admin for access."
                : (permission.Contains("Manager") && level < 20)
                ? "You do not have sufficient privileges!"
                : !(permission.Contains("Manager") && permission.Contains("Manager"))
                ? "You do not have sufficient privileges." : "");
        }

        public static void VariableScope()
        {
            goto Current;
            bool flag = true;
            int value;
            if (true)
            {
                value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }
            Console.WriteLine($"Outside the code block: {value}");

            // knowledge check
            int first = 5;
            if (first > 0)
            {
                int second = 6;
                first += second;
            }
            Console.WriteLine(first);

            // unit 3
            flag = true;
            if (flag) Console.WriteLine(flag);

            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else
            {

                Console.WriteLine("Found Chunk");
            }

            // make this code more readable
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }

            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");

            int one = 1;
            if (one > 0)
            {
                int second = 8;
                one += second;
            }
            Console.WriteLine(one);

        Current:
            int sum = 5;
            if (sum > 0)
            {
                int six = 6;
            }
            //sum += six; won't complile
            Console.WriteLine(sum);
        }

        public static void SwitchStatements()
        {
            goto current;
            int emplyeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (emplyeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"{employeeName}, {title}");
        current:
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";
            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");

        }

        public static void ForLoops()
        {
            goto current;
            for (int i = 10; i >= 10; i--)
            {
                Console.WriteLine(i);
            }

            // optional
            //for (; ; )
            //    Console.WriteLine("Infinity and Beyond!");

            string[] names = ["Alex", "Eddie", "David", "Michael"];

            // can modify array using for but not foreach
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";
            foreach (string name in names)
                Console.WriteLine(name);

            current:
            //FizzBuzz challenge
            for (int i = 1; i <= 100; i++)
            {
                bool divisibleByThree = false;
                bool divisibleByFive = false;

                if (i % 3 == 0) divisibleByThree = true;
                if (i % 5 == 0) divisibleByFive = true;

                Console.WriteLine($"{i}" +
                    $"{(divisibleByThree || divisibleByFive ? " - " : "")}" +
                    $"{(divisibleByThree ? "Fizz" : "")}" +
                    $"{(divisibleByFive ? "Buzz" : "")}");
            }
        }

        public static void DoWhile()
        {
            goto current;
            int current;
            int interation = 0;
            //do
            //{
            //    Random random = new Random();
            //    current = random.Next(1, 11);
            //    Console.WriteLine($"{current}");
            //    interation++;
            //} while (current != 7);

            Random random = new Random();
            current = random.Next(1, 11);

            while (current >= 3)
            {
                Console.WriteLine($"{current}");
                interation++;
            }
            Console.WriteLine($"Wow! It only took {interation} interations to randomize a 7!");

            // rpg challenge!
            int heroHP = 10;
            int monsterHP = 10;
            Random damage = new Random();
            do
            {
                // hero attack
                int roll = damage.Next(1, 11);
                monsterHP -= roll;
                Console.WriteLine($"Hero performs karate kick for {roll} damage! Monster HP is now {monsterHP}");

                // monter attack
                roll = damage.Next(1, 11);
                if (monsterHP > 0)
                {
                    heroHP -= roll;
                    Console.WriteLine($"Monster performs fire breath for {roll} damage! Hero HP is now {heroHP}");
                }

            } while (heroHP > 0 && monsterHP > 0);
            Console.WriteLine(heroHP > monsterHP ? "Hero Wins!" : "Monster Wins!");

            // code project 1

            Console.WriteLine("Please enter a value between 5 and 10!");
            string? input;
            bool validInput = false;
            bool terminatingCondition = false;
            do
            {
                int value;
                input = Console.ReadLine();
                validInput = int.TryParse(input, out value);

                if (validInput)
                {
                    if (!(value >= 5 && value <= 10))
                    {
                        Console.WriteLine("Enter an integer value between 5 and 10!");
                    }
                    else
                    {
                        terminatingCondition = true;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            }
            while (!terminatingCondition);
            Console.WriteLine($"Your input value ({input}) has been accepted.");

            // code project 2
            Console.WriteLine("Are you Administrator, Manager, or User?");
            string? role;
            validInput = false;
            do
            {
                input = Console.ReadLine();
                role = input?.Trim().ToLower();
                if ((role == "administrator" || role == "manager" || role == "user"))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid entry! The role you enter, ({input}) is not valid.\nEnter your role name (Administrator, Manager, or User)");
                }
            }
            while (!validInput);
            Console.WriteLine($"Your input value ({role}) has been accepted.");

        // code project 3 TODO: This works, but not as efficient as it could be, IF the string from the array does not contain a '.' just output it outside of the while loop.
        current:
            string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            for (int i = 0; i <= myStrings.Length - 1; i++)
            {
                int periodLocation = 0;
                string myString = myStrings[i];
                string sentence;
                while (periodLocation != -1)
                {
                    periodLocation = myString.IndexOf('.');
                    string subString = myString.Substring(periodLocation + 1);
                    subString = subString.TrimStart();
                    if (periodLocation != -1)
                        sentence = myString.Remove(periodLocation);
                    else
                        sentence = myString;
                    Console.WriteLine(sentence);
                    myString = subString;
                }
            }
        }

        public static void DataTypes()
        {
            goto current;
            Console.WriteLine("Signed intergral types:");

            Console.WriteLine($"sbyte    : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short    : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int      : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long     : {long.MinValue} to {long.MaxValue}");


            Console.WriteLine("");
            Console.WriteLine("Unsigned intergral types:");
            Console.WriteLine($"byte     : {byte.MinValue} to {byte.MaxValue}"); // we found it!!!!
            Console.WriteLine($"ushort   : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint     : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong    : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float    : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)"); // base 2 good for approximations - smaller memory footprint
            Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)"); // base 2 good for approximations - smaller memory footprint
            Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)"); //base 10 for precision - larger memory footprint
                                                                                                                        // eleven (11) different numeric data types!

        current:
            int[] data = new int[3];
            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);
            string aString = new String("Hello World");
            Console.WriteLine(aString);
            Console.WriteLine(new String("Hi!"));
            shortenedString = new String("Hello");


            // difference between value and reference types
            int val_A = 2;
            int val_B = val_A;
            Console.WriteLine($"val_B: {val_B}");
            val_B = 5;

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}");
            Console.WriteLine($"val_B: {val_B}");

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;    // points to same memory REFERENCE
            ref_B[0] = 5;           // both values changed, same memory location

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }
        public static void CastingTypes()
        {
            goto current;
        //int first = 2;
        //string second = "4";
        //int result = first + int.Parse(second);
        ////string result = first + second; // safe conversion return 24, lol
        //Console.WriteLine(result);

        //// int to decimal is widening conversion, decimal can hold more information than int
        //int myInt = 3;
        //Console.WriteLine($"int: {myInt}");

        //    decimal myDecimal = myInt; // implicit conversion
        //    Console.WriteLine($"decimal: {myDecimal}");


        //    decimal myPiDecimal = 3.14m;
        //    Console.WriteLine($"decimal: {myPiDecimal}");

        //    // narrowing conversion becuase int cannot hold more information than decimal, chance to lose things.
        //    int myPiInt = (int)myPiDecimal; // explicit conversion, going to lose the decimal! 
        //    Console.WriteLine(myPiInt);

        //decimal myDecimal = 1.23456789m;
        //float myFloat = (float)myDecimal;

        //Console.WriteLine($"Decimal  : {myDecimal}");
        //Console.WriteLine($"Float    : {myFloat}");

        //int first = 5;
        //int second = 7;
        //string message = first.ToString() + second.ToString();
        //Console.WriteLine(message);

        //string first = "5";
        //string second = "7";
        //int sum = int.Parse(first) + int.Parse(second); // user type helper method int.Parse
        //Console.WriteLine(sum);

        //string value1 = "5";
        //string value2 = "7";
        //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2); // helper method Convert
        //Console.WriteLine(result);

        //int value = (int)1.5m; // casting trucates
        //Console.WriteLine(value);

        //int value2 = Convert.ToInt32(1.5m); // converting rounds up, if 1.499m will round down! 80
        //Console.WriteLine(value2);

        //string value = "102";
        //int result;
        //if (int.TryParse(value, out result))
        //{
        //    Console.WriteLine($"Measurement: {result}");
        //}
        //else
        //{
        //    Console.WriteLine("Unable to report the measurement.");
        //}
        //if (result > 0)
        //    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

        //int z;
        //funOut(out z);
        //Console.WriteLine(z);

        //    string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        //    string message = String.Empty;
        //    decimal total = 0m;
        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        decimal result;
        //        if (decimal.TryParse(values[i], out result))
        //        {
        //            total += result;
        //        }
        //        else
        //        {
        //            message += values[i];
        //        }
        //    }
        //    Console.WriteLine($"Message: {message}\nTotal: {total}");
        //}

        current:
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = value2 / Convert.ToDecimal(value3);
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

        }
        //public static void funOut(out int x)
        //{
        //    x = 1;
        //}

        public static void Pallets()
        {
            //string[] pallets = ["B14", "A11", "B12", "A13"];

            ////Console.WriteLine("Sorted...");
            ////Array.Sort(pallets); // helper methods for Array TYPE Sort
            ////foreach (var pallet in pallets)
            ////{
            ////    Console.WriteLine($"-- {pallet}");
            ////}

            ////Console.WriteLine("");
            ////Console.WriteLine("Reversed...");
            ////Array.Reverse(pallets); // helper methods for Array TYPE Reverse
            ////foreach (var pallet in pallets)
            ////{
            ////    Console.WriteLine($"-- {pallet}");
            ////}

            //Console.WriteLine("");

            ////Console.WriteLine($"Before: {pallets[0].ToLower()}");
            //Array.Clear(pallets, 0, 2);
            ////if (pallets[0] != null)
            ////    Console.WriteLine($"After: {pallets[0].ToLower()}");

            //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            //foreach (string pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 6); // pass in array by reference
            //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            //pallets[4] = "C01";
            //pallets[5] = "C02";

            //foreach (string pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Array.Resize(ref pallets, 3);
            //Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            //foreach (string pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();
            //Array.Reverse(valueArray);
            //// string result = new string(valueArray); // need to use the string class constructor
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);

            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine(item);
            //}

            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                Array.Reverse(letters);
                words[i] = new string(letters);
            }
            string result = String.Join(" ", words);
            Console.WriteLine(result);
            Console.WriteLine();

            // lol first time!! xD - next time instead of placing them BACK into the array, create a new array.
            // string[] newMessage = new string[words.Length];

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orders = orderStream.Split(",");
            Array.Sort(orders);
            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i].Length != 4)
                    Console.WriteLine($"{orders[i]}\t- Error");
                else
                    Console.WriteLine(orders[i]);
            }
            // too easy xD! the example uses a foreach and equal comparison but... erm!
            // whats important to remember are these are helper methods to String and Array types... not extension methods to string[] and string values!!!!
        }
        public static void CompositeFormatting()
        {
            //string first = "Hello";
            //string second = "World";
            ////string result = string.Format("{0} {1}!", first, second); // "{0} {1}!" forms the template
            ////Console.WriteLine(result);
            //Console.WriteLine("{1} {0}!", first, second);
            //Console.WriteLine("{0} {0} {0}!", first, second);

            //Console.WriteLine($"{first} {second}!");
            //Console.WriteLine($"{second} {first}!");
            //Console.WriteLine($"{first} {first} {first}!"); // string interpolation perferred over composite formatting

            //decimal price = 123.45m;
            //int discount = 50;
            //Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // :C added currency to decimal and int

            //decimal measurement = 123456.78912m;
            //Console.WriteLine($"Measurement: {measurement:N} units"); // :N added commas for thousands, millions, billions...

            //Console.WriteLine($"Measurement: {measurement:N4} units"); // for :N the default is 2 decimals. for more add a number ex: :N4

            //decimal tax = .36785m;
            //Console.WriteLine($"Tax rate: {tax:P2}"); // percentage rounded to 2 decimal places.

            //price = 67.55m;
            //decimal salePrice = 59.99m;

            //string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price); // do not actually need the decimal indicator of 2 here xD
            //yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";

            //Console.WriteLine(yourDiscount);

            //int invoiceNumber = 1201;
            //decimal productShares = 25.4568m;
            //decimal subTotal = 2750.00m;
            //decimal taxPercentage = .15825m;
            //decimal total = 3185.19m;

            //Console.WriteLine($"Invoice Number: {invoiceNumber}");
            //Console.WriteLine($"    Shares:     {productShares:N3} Product");
            //Console.WriteLine($"        Sub Total:  {subTotal:C}");
            //Console.WriteLine($"            Tax: {taxPercentage:P2}");
            //Console.WriteLine($"        Total Billed:   {total:C}");

            //string input = "Pad this";
            //Console.WriteLine(input.PadLeft(12));
            //Console.WriteLine(input.PadRight(12));
            //Console.WriteLine(input.PadLeft(12, '/'));
            //Console.WriteLine(input.PadRight(12, '/'));

            //string paymentId = "769C";
            //string payeeName = "Mr. Stephen Ortega";
            //string paymentAmount = "$5,000.00";

            //var formattedLine = paymentId.PadRight(6);
            //formattedLine += payeeName.PadRight(24);
            //formattedLine += paymentAmount.PadLeft(10);

            //Console.WriteLine("1234567890123456789012345678901234567890");
            //Console.WriteLine(formattedLine);

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            string message = $"Dear {customerName},\n";
            message += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
            message += $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P}.\n\n";
            message += $"Our new product, {newProduct} offers a return of {newReturn:P}.  ";
            message += $"Given your current volume, your potential profit would be {newProfit:C2}\n";
            
            Console.WriteLine(message);

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = $"{currentProduct}".PadRight(20);
            comparisonMessage += $"{currentReturn:P2}".PadRight(10);
            comparisonMessage += $"{currentProfit:C2}".PadRight(20);
            comparisonMessage += "\n";
            comparisonMessage += $"{newProduct}".PadRight(20);
            comparisonMessage += $"{newReturn:P2}".PadRight(10);
            comparisonMessage += $"{newProfit:C2}".PadRight(20);

            Console.WriteLine(comparisonMessage);
        }

        public static void ParseStrings()
        {
            //string message = "Find what is (inside the parenthesis)";

            //int openingPosition = message.IndexOf('(') + 1; // zero-based
            //int closingPosition = message.IndexOf(')'); // zero-based

            //Console.WriteLine(openingPosition);
            //Console.WriteLine(closingPosition);

            //openingPosition += 1; // do not inluude the strting position

            //int lenth = closingPosition - openingPosition;

            //Console.WriteLine(message.Substring(openingPosition, lenth));

            //string message = "What is the value <span>between the tags</span>?";
            //const string openSpan = "<span>"; // no magic strings
            //const string closeSpan = "</span>";

            //int startingPosition = message.IndexOf(openSpan);
            //int closingPosition = message.IndexOf(closeSpan);
            //startingPosition += closeSpan.Length; // no magic number
            //int length = closingPosition - startingPosition;
            //Console.WriteLine(message.Substring(startingPosition, length));

            //string message = "hello there!";

            //int first_h = message.IndexOf('h');
            //int last_h = message.LastIndexOf('h');

            //Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
            //Console.WriteLine();

            //message = "(What if) I am (only interested) in the last (set of parenthesis)?";

            //int lastStartingParen = message.LastIndexOf('(');
            //lastStartingParen += 1;

            //int lastEndingParen = message.LastIndexOf(')');
            //int length = lastEndingParen - lastStartingParen;
            //Console.WriteLine(message.Substring(lastStartingParen, length));
            //Console.WriteLine("");

            //message = "(What if) there are (more than) one (set of parenthesis)?";
            //while (true)
            //{
            //    int openingPosition = message.IndexOf('(');
            //    if (openingPosition == -1) break; // this is for the '?' that remains in the last loop

            //    openingPosition += 1;
            //    int closingPosition = message.IndexOf(')');
            //    length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length));

            //    message = message.Substring(closingPosition + 1); // leaves what we require for the next loop
            //}

            //message = "Hello, world!";
            //char[] charsToFind = { 'a', 'e', 'i' };

            //int index = message.IndexOfAny(charsToFind);

            //Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
            //Console.WriteLine();

            //string message = "Help (find) the {opening symbols}";
            //Console.WriteLine($"Searching THIS Message: {message}");
            //char[] openSymbols = { '[', '{', '(' };
            //int startPosition = 5;
            //int openingPosition = message.IndexOfAny(openSymbols);
            //Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            //openingPosition = message.IndexOfAny(openSymbols, startPosition);
            //Console.WriteLine($"Found WITH using startPosition { startPosition}: { message.Substring(openingPosition)}");

            //string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            //char[] openSymbols = { '[', '{', '(' };
            //int closingPosition = 0;
            //while (true)
            //{
            //    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
            //    if (openingPosition == -1) break;

            //    string currentSymbol = message.Substring(openingPosition, 1);

            //    char matchingSymbol = ' ';

            //    switch (currentSymbol)
            //    {
            //        case "[":
            //            matchingSymbol = ']';
            //            break;
            //        case "{":
            //            matchingSymbol = '}';
            //            break;
            //        case "(":
            //            matchingSymbol = ')';
            //            break;
            //    }

            //    openingPosition += 1;
            //    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            //    int length = closingPosition - openingPosition;
            //    Console.WriteLine(message.Substring(openingPosition, length));
            //}

            //string data = "12345John Smith          5000  3  ";
            //string updatedData = data.Remove(5, 20);
            //Console.WriteLine(updatedData);

            //string message = "This--is--ex-amp-le--da-ta";
            //message = message.Replace("--", " ");
            //message = message.Replace("-", "");
            //Console.WriteLine(message);

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            const string startingSpan = "<span>";
            const string endingSpan = "</span>";
            int startingPosition = input.IndexOf(startingSpan);
            startingPosition += startingSpan.Length;
            int endingPosition = input.LastIndexOf(endingSpan);
            int length = endingPosition - startingPosition;
            quantity = input.Substring(startingPosition, length);
            quantity = $"Quantity: {quantity}";

            const string startingDiv = "<div>";
            const string endingDiv = "</div>";
            string output = input.Replace(startingDiv, "");
            output = output.Replace(endingDiv, "");
            output = output.Replace("&trade", "&reg");
            output = $"Output: {output}";

            // Your work here

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
    }
}
