using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
            //ParseStrings();
            //Emumerators();
            PassBy();
            Console.Read();
        }

        public static void GradedAssignments()
        {
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

            string reversedMessage = new string(letters);

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
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine(flip == 1 ? "heads" : "tails");

            string permission = "Admin|Manager";
            
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
            int sum = 5;
            if (sum > 0)
            {
                //int six = 6;
            }
            Console.WriteLine(sum);
        }

        public static void SwitchStatements()
        {
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
            int[] ref_B = ref_A;   
            ref_B[0] = 5;          

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }
        public static void CastingTypes()
        {
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = Convert.ToInt32(value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / Convert.ToDecimal(value3);
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

        }
        public static void Pallets()
        {
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
        }
        public static void CompositeFormatting()
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

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

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
        public static void Emumerators()
        {
            BlogSimulator bs = new BlogSimulator();
            bs.Run();

            var inter = bs.GetEnumerator();
            inter.MoveNext();
            Blog blob1 = (Blog)inter.Current;
            Console.WriteLine($"{blob1.Author}\t{blob1.Title}\t{blob1.Published}");
            inter.MoveNext();
            Blog blob2 = (Blog)inter.Current;
            Console.WriteLine($"{blob2.Author}\t\t{blob2.Title}\t{blob2.Published}");
            inter.MoveNext();
            Blog blob3 = (Blog)inter.Current;
            Console.WriteLine($"{blob3.Author}\t{blob3.Title}\t{blob3.Published}");
            Console.WriteLine();

            foreach (Blog blog in bs)
            {
                if (blog.Author == "Metsker")
                    Console.WriteLine($"{blog.Author}\t\t{blog.Title}\t{blog.Published}");
                else
                    Console.WriteLine($"{blog.Author}\t{blog.Title}\t{blog.Published}");
            }
        }

        public static void PassBy()
        { 
            string[] byRef = { "ref" };
            int byVal = 100;
            PassInto(byRef, byVal);
            Console.WriteLine($"Original Values byVal:{byVal} byRef:{byRef[0]}");
        }

        public static void PassInto(string[] passString, int passInt)
        {
            passString[0] = "test";
            passInt++;
            Console.WriteLine($"Modified Values byVal:{passInt} byRef:{passString[0]}");
        }

    }

    public class Simulator : IEnumerable
    {
        int[] newValues = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            foreach (int i in newValues)
            {
                yield return i;
            }
        }
    }

    public class Blog
    {
        public string Author { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public DateTime Published { get; set; }
    }

    public class BlogSimulator : IEnumerable
    {
        public Blog[] blogs = new Blog[3];
        public void Run()
        {
            Blog blog1 = new Blog();
            blog1.Title = "C# IEumerables";
            blog1.Author = "Judith Bishop";
            blog1.Published = DateTime.Now;
            blogs[0] = blog1;

            Blog blog2 = new Blog();
            blog2.Title = "C# IEumerators";
            blog2.Author = "Metsker";
            blog2.Published = DateTime.Now;
            blogs[1] = blog2;

            Blog blog3 = new Blog();
            blog3.Title = "C# Lists";
            blog3.Author = "Hejlsberg";
            blog3.Published = DateTime.Now;
            blogs[2] = blog3;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Blog blog in blogs)
                yield return blog;
        }

    }

}
