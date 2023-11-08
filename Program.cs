using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace LibraryAppp
{
    class UserAuthentication
    {
        public string storedUsername = "ABC";
        public string storedPassword = "123";
        //public int storedAge = 18;

        public bool Credentials(string provUsername, string provPassword) //int provAge
        {
            bool result = provUsername == storedUsername && provPassword == storedPassword;//&& provAge >= storedAge;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserAuthentication auth = new UserAuthentication();
            int attempts = 1;
            int maxAttempts = 3;
            bool authenticated = false;
            // int age = 0;

            while (attempts <= maxAttempts && !authenticated)
            {
                Console.WriteLine("Enter Username:");
                string uname = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                string pass = Console.ReadLine();
                //Console.WriteLine("Enter Age:");

                //if (!int.TryParse(Console.ReadLine(), out age))
                //{
                //    Console.WriteLine("Invalid age format. Please enter a valid age.");
                //    continue;
                //}

                authenticated = auth.Credentials(uname, pass); //age

                if (authenticated)
                {
                    Console.WriteLine("Authentication Successful");
                }
                else
                {
                    Console.WriteLine("\nAuthentication Failed! Enter correct credentials!\n");
                }
                attempts++;
            }

            if (attempts >= maxAttempts && !authenticated)
            {
                Console.WriteLine("Maximum login attempts reached. You are locked out.");
                return;
            }

            // entering age and validating it

            Console.WriteLine("\nPlease Enter your Age");
            int totalSpending = 0;
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("\nEnter valid age!");
            }

            //BOOK SELECTION BASED ON AGE
            if (age >= 5 && age <= 10)
            {
                Console.WriteLine("\nSelect your book:\n1. A Day with Yayah\n2. AGRIman AGventures\n3. Berry Magic");
                int bookChoice;

                if (int.TryParse(Console.ReadLine(), out bookChoice))
                {
                    switch (bookChoice)
                    {
                        case 1:
                            totalSpending = 1000;
                            Console.WriteLine("You purchased \"A Day with Yayah\"");
                            break;
                        case 2:
                            totalSpending = 1000;
                            Console.WriteLine("You purchased \"AGRIman AGventures\"");
                            break;
                        case 3:
                            totalSpending = 1000;
                            Console.WriteLine("You purchased \"Berry Magic\"");
                            break;
                        default:
                            Console.WriteLine("Invalid book choice");
                            break;
                    }
                }
                Console.WriteLine("\nDo you want to select more books?\n 1.Yes \n 2.No\n");
                char choose = Console.ReadKey().KeyChar;
                switch (choose)
                {
                    case '1':

                        if (age >= 5 && age <= 10)
                        {
                            Console.WriteLine("\nSelect your book:\n1. A Day with Yayah\n2. AGRIman AGventures\n3. Berry Magic");
                            int booksChoice;

                            if (int.TryParse(Console.ReadLine(), out booksChoice))
                            {
                                switch (booksChoice)
                                {
                                    case 1:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"A Day with Yayah\"");
                                        break;
                                    case 2:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"AGRIman AGventures\"");
                                        break;
                                    case 3:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"Berry Magic\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }

                        else if (age >= 11 && age <= 18)
                        {
                            Console.WriteLine("\nSelect your book:\n1. The Hunger Games\n2. The Outsiders\n3. To Kill a Mockingbird");
                            int bookChoice2;

                            if (int.TryParse(Console.ReadLine(), out bookChoice2))
                            {
                                switch (bookChoice2)
                                {
                                    case 1:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Hunger Games\"");
                                        break;
                                    case 2:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Outsiders\"");
                                        break;
                                    case 3:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"To Kill a Mockingbird\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        else if (age >= 19 && age <= 25)
                        {
                            Console.WriteLine("\nSelect your book:\n1. Atomic Habits\n2. The Alchemist\n3. The 7 Habits of Highly Effective People");
                            int booksChoice3;

                            if (int.TryParse(Console.ReadLine(), out booksChoice3))
                            {
                                switch (booksChoice3)
                                {
                                    case 1:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"Atomic Habits\"");
                                        break;
                                    case 2:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The Alchemist\"");
                                        break;
                                    case 3:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The 7 Habits of Highly Effective People\"");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        break;

                    case '2':
                        
                        double dis = CalculateDiscount(totalSpending);

                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine("INVOICE 001.");
                        Console.WriteLine("-------------------------");

                        Console.WriteLine("\nYour total spending is: $" + totalSpending);
                        Console.WriteLine("\nYour Discount Percentage is: " + dis + "%");
                        double disAmount = (totalSpending * dis) / 100;
                        Console.WriteLine("\nThe discounted amount is: $" + disAmount);
                        double disSpending = totalSpending - disAmount;
                        Console.WriteLine("\nAmount after discount is: $" + disSpending);
                        return;
                        break;
                    default:
                        Console.WriteLine("Press a valid Key!");
                        break;

                }
            }

            if (age >= 11 && age <= 18)
            {
                Console.WriteLine("\nSelect your book:\n1. The Hunger Games\n2. The Outsiders\n3. To Kill a Mockingbird");
                int bookChoice2;

                if (int.TryParse(Console.ReadLine(), out bookChoice2))
                {
                    switch (bookChoice2)
                    {
                        case 1:
                            totalSpending = 2500;
                            Console.WriteLine("You purchased \"The Hunger Games\"");
                            break;
                        case 2:
                            totalSpending = 2500;
                            Console.WriteLine("You purchased \"The Outsiders\"");
                            break;
                        case 3:
                            totalSpending = 2500;
                            Console.WriteLine("You purchased \"To Kill a Mockingbird\"");
                            break;
                        default:
                            Console.WriteLine("Invalid book choice");
                            break;
                    }
                }
                Console.WriteLine("\nDo you want to select more books?\n 1.Yes \n 2.No\n");
                char choose = Console.ReadKey().KeyChar;
                switch (choose)
                {
                    case '1':

                        if (age >= 5 && age <= 10)
                        {
                            Console.WriteLine("\nSelect your book:\n1. A Day with Yayah\n2. AGRIman AGventures\n3. Berry Magic");
                            int bookChoice;

                            if (int.TryParse(Console.ReadLine(), out bookChoice))
                            {
                                switch (bookChoice)
                                {
                                    case 1:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"A Day with Yayah\"");
                                        break;
                                    case 2:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"AGRIman AGventures\"");
                                        break;
                                    case 3:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"Berry Magic\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }

                        else if (age >= 11 && age <= 18)
                        {
                            Console.WriteLine("\nSelect your book:\n1. The Hunger Games\n2. The Outsiders\n3. To Kill a Mockingbird");
                            int booksChoice2;

                            if (int.TryParse(Console.ReadLine(), out booksChoice2))
                            {
                                switch (booksChoice2)
                                {
                                    case 1:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Hunger Games\"");
                                        break;
                                    case 2:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Outsiders\"");
                                        break;
                                    case 3:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"To Kill a Mockingbird\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        else if (age >= 19 && age <= 25)
                        {
                            Console.WriteLine("\nSelect your book:\n1. Atomic Habits\n2. The Alchemist\n3. The 7 Habits of Highly Effective People");
                            int booksChoice3;

                            if (int.TryParse(Console.ReadLine(), out booksChoice3))
                            {
                                switch (booksChoice3)
                                {
                                    case 1:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"Atomic Habits\"");
                                        break;
                                    case 2:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The Alchemist\"");
                                        break;
                                    case 3:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The 7 Habits of Highly Effective People\"");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        break;

                    case '2':
                       
                        double dis = CalculateDiscount(totalSpending);

                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine("INVOICE 001.");
                        Console.WriteLine("-------------------------");

                        Console.WriteLine("\nYour total spending is: $" + totalSpending);
                        Console.WriteLine("\nYour Discount Percentage is: " + dis + "%");
                        double disAmount = (totalSpending * dis) / 100;
                        Console.WriteLine("\nThe discounted amount is: $" + disAmount);
                        double disSpending = totalSpending - disAmount;
                        Console.WriteLine("\nAmount after discount is: $" + disSpending);
                        return;
                        break;
                    default:
                        Console.WriteLine("Press a valid Key!");
                        break;

                }
            }


            if (age >= 19 && age <= 25)
            {
                Console.WriteLine("\nSelect your book:\n1. Atomic Habits\n2. The Alchemist\n3. The 7 Habits of Highly Effective People");
                int bookChoice3;

                if (int.TryParse(Console.ReadLine(), out bookChoice3))
                {
                    switch (bookChoice3)
                    {
                        case 1:
                            totalSpending = 3500;
                            Console.WriteLine("You purchased \"Atomic Habits\"");
                            break;
                        case 2:
                            totalSpending = 3500;
                            Console.WriteLine("You purchased \"The Alchemist\"");
                            break;
                        case 3:
                            totalSpending = 3500;
                            Console.WriteLine("You purchased \"The 7 Habits of Highly Effective People\"");
                            break;
                        default:
                            Console.WriteLine("Invalid book choice");
                            break;
                    }
                }


               
                Console.WriteLine("\nDo you want to select more books?\n 1.Yes \n 2.No\n");
                char choose = Console.ReadKey().KeyChar;
                switch (choose)
                {
                    case '1':

                        if (age >= 5 && age <= 10)
                        {
                            Console.WriteLine("\nSelect your book:\n1. A Day with Yayah\n2. AGRIman AGventures\n3. Berry Magic");
                            int bookChoice;

                            if (int.TryParse(Console.ReadLine(), out bookChoice))
                            {
                                switch (bookChoice)
                                {
                                    case 1:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"A Day with Yayah\"");
                                        break;
                                    case 2:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"AGRIman AGventures\"");
                                        break;
                                    case 3:
                                        totalSpending += 1000;
                                        Console.WriteLine("You purchased \"Berry Magic\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }

                        else if (age >= 11 && age <= 18)
                        {
                            Console.WriteLine("\nSelect your book:\n1. The Hunger Games\n2. The Outsiders\n3. To Kill a Mockingbird");
                            int bookChoice2;

                            if (int.TryParse(Console.ReadLine(), out bookChoice2))
                            {
                                switch (bookChoice2)
                                {
                                    case 1:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Hunger Games\"");
                                        break;
                                    case 2:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"The Outsiders\"");
                                        break;
                                    case 3:
                                        totalSpending += 2500;
                                        Console.WriteLine("You purchased \"To Kill a Mockingbird\"");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        else if (age >= 19 && age <= 25)
                        {
                            Console.WriteLine("\nSelect your book:\n1. Atomic Habits\n2. The Alchemist\n3. The 7 Habits of Highly Effective People");
                            int booksChoice3;

                            if (int.TryParse(Console.ReadLine(), out booksChoice3))
                            {
                                switch (bookChoice3)
                                {
                                    case 1:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"Atomic Habits\"");
                                        break;
                                    case 2:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The Alchemist\"");
                                        break;
                                    case 3:
                                        totalSpending += 3500;
                                        Console.WriteLine("You purchased \"The 7 Habits of Highly Effective People\"");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid book choice");
                                        break;
                                }
                            }
                        }
                        break;

                    case '2':
                       
                        double dis = CalculateDiscount(totalSpending);

                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine("INVOICE 001.");
                        Console.WriteLine("-------------------------");

                        Console.WriteLine("\nYour total spending is: $" + totalSpending);
                        Console.WriteLine("\nYour Discount Percentage is: " + dis + "%");
                        double disAmount = (totalSpending * dis) / 100;
                        Console.WriteLine("\nThe discounted amount is: $" + disAmount);
                        double disSpending = totalSpending - disAmount;
                        Console.WriteLine("\nAmount after discount is: $" + disSpending);
                        return;
                        break;
                    default:
                        Console.WriteLine("Press a valid Key!");
                        break;

                }
            }

            // Discounts based on the total spending
            static double CalculateDiscount(int totalSpending)
            {
                double discount = 0.0;

                if (totalSpending <= 2000)
                {
                    discount = 10.0;
                }
                else if (totalSpending <= 5000)
                {
                    discount = 20.0;
                }
                else if (totalSpending <= 7000)
                {
                    discount = 30.0;
                }

                return discount;
            }

            // Calculate discount based on the total spending
            double discount = CalculateDiscount(totalSpending);

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("INVOICE 001.");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\nYour total spending is: $" + totalSpending);
            Console.WriteLine("\nYour Discount Percentage is: " + discount + "%");
            double discountAmount = (totalSpending * discount) / 100;
            Console.WriteLine("\nThe discounted amount is: $" + discountAmount);
            double discountedSpending = totalSpending - discountAmount;
            Console.WriteLine("\nAmount after discount is: $" + discountedSpending);
        }

    }
}





