using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Transactions;

namespace Grades
{
    internal class Program
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
            ContosoPets();
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

        public static void ContosoPets()
        { 
            
        }
    }
}