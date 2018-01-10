using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            foreach (string fruit in LFruits)
            {
                Console.Write(fruit + ", ");
            }


            Console.WriteLine();

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);


            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = from name in names
                                          orderby name[0] descending
                                          select name;

            foreach (string name in descend)
            {
                Console.Write(name + ", ");
            }


            Console.WriteLine();

            // Build a collection of these numbers sorted in ascending order
            List<int> moreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine();

            IEnumerable<int> ascendingNumbers = from num in moreNumbers
                                                orderby num ascending
                                                select num;

            foreach (int num in ascendingNumbers)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();

            // Output how many numbers are in this list
            List<int> andMoreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine(andMoreNumbers.Count);


            Console.WriteLine();

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double totalPurchases = purchases.Sum();

            Console.WriteLine($"The total amount is ${totalPurchases}");


            Console.WriteLine();


            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double mostExpensiveItem = prices.Max();

            Console.WriteLine($"The most expensive item is ${mostExpensiveItem}");


            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            // method using linq
            IEnumerable<int> noSquareRoots = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0);
            noSquareRoots.ToList().ForEach(num => Console.Write(num + ", "));


            // verbose method that doesn't use Linq
            // List<int> noSquareRoots = new List<int>();

            // for (int i; i < wheresSquaredo.Count; i++ ) {
            //     if (Math.Sqrt(wheresSquaredo[i])%1 != 0) {
            //         noSquareRoots.Add(wheresSquaredo[i]);
            //     } else {
            //         break;
            //     }
            // } 

            Console.WriteLine();



            // List<Customer> customers = new List<Customer>() {
            //     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            //     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            //     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            //     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            //     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            //     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            //     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            //     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            //     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            //     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            // };


            // List<Customer> millionaires = customers.Where(c => c.Balance >= 100000).ToList();


            // /*
            //     Given the same customer set, display how many millionaires per bank.
            //     Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            //     Example Output:
            //     WF 2
            //     BOA 1
            //     FTB 1
            //     CITI 1
            // */

            // // millionaires.OrderBy()
            // Console.WriteLine();


            // var results = from cust in customers
            //               group cust.Name by cust.Bank into grp
            //               select new
            //               {
            //                   Bank =
            //                   grp.Key,
            //                   Customers = grp.ToList()
            //               };

            // results.ToList();

            // foreach (var result in results)
            // {
            //     Console.WriteLine($"{result.Bank} has {result.Customers.Count} millionaires");
            // }


            // Steve's code example
            //  var groupedMillionaires = from customer in millionaires
            //         group customer by customer.Bank into millionaireGroup
            //         select new {
            //             Bank = millionaireGroup.Key,
            //             NumberOfMillionaires = millionaireGroup.Count()
            //         };

            /*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/


            Console.WriteLine();

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var millionaireReport = from bank in banks
                                    join c in customers on bank.Symbol equals c.Bank
                                    select new { Bank = bank.Name, Name = c.Name.Split(" ") };
                                                

            millionaireReport.OrderBy(c => c.Name[1]).ToList().ForEach(c => {
                Console.WriteLine($"{c.Name[0]} {c.Name[1]} at {c.Bank}");
            });

            // millionaireReport.ToList().ForEach(cust => {
            //     string bank = cust.Bank;

            //     foreach (Customer customer in cust.Name) 
            //     {
            //         Console.WriteLine($"{customer.Name} at {bank}");
            //     }
            // });

        

            // foreach (Customer customer in millionaireReport)
            // {
            //     Console.WriteLine($"{customer.Name} at {customer.Bank}");
            // }




        }
    }
}
