 using System;  
 namespace Practice 
 {
public class def 
{  
    public static void Main(string [] args)
    {  
   
        List<string> S = new List<string>()  
        {  
           "roses are red", "bottle also red", "violets blue", "Laptop"
        };

        // Query syntax

        var r = from P in S  
                where P.Contains("red")  
                select P;    
        foreach(var i in r)  
        {  
            Console.WriteLine(i);  
        }  

         // Method syntax

         var r1 = S.Where(a=> a.Contains("red")); 
        foreach(var i in r1)  
        {  
            Console.WriteLine(i);  
        }  


           // Min Function

            int[] a = { 10, 3, 57, 30, 56, 92, 74, 16, 34, 23, 5, 8 };  
            int minNum= a.Min();  
            Console.WriteLine("Mininum number is {0}",minNum);  

            // Max Function

            int[] b = { 10, 3, 57, 30, 56, 92, 74, 16, 34, 23, 5, 8 };  
            int maxNum= a.Max();  
            Console.WriteLine("Maximum number is {0}",maxNum); 

            // Sum Function

            int[] s = { 10, 3, 57, 30, 56, 92, 74, 16, 34, 23, 5, 8 };  
            int sum= a.Sum();  
            Console.WriteLine("sum is {0}",sum); 

            // count function

            int[] c = { 10, 3, 57, 30, 56, 92, 74, 16, 34, 23, 5, 8 }; 
            int count = c.Count(); 
            Console.WriteLine("The Count is {0}", count);  

            // Aggregate function

            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double Agg = Num.Aggregate((a, b) => a * b);
            Console.WriteLine("Product is {0}", Agg); 

            string[] z = { "a", "b", "c", "d" };  
            var C = z.Aggregate((a, b) => a + ',' + b);  
            Console.WriteLine("the Concatenated String is {0}", C); 

            // Partition Operators
            // Take
            string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };  
            var R = countries.Take(4);  
            foreach (var D in R)  
            {  
                Console.WriteLine(D);  
            }  

            // TakeWhile
            string[] items = { "Bag" , "Bottle" , "Book" , "Laptop" , "Pen"}; 
            IEnumerable<string> result = items.TakeWhile(x => x.StartsWith("B"));  
            foreach (string p in  result)   
            {  
                Console.WriteLine(p);  
            }  

            // Skip
            string[] items1 = { "Bag" , "Bottle" , "Book" , "Laptop" , "Pen"}; 
            IEnumerable<string> result1 = items1.Skip(2);  
            foreach (string p1 in  result1)   
            {  
                Console.WriteLine(p1);  
            }

        // Synchronous

            Synchronous G = new Synchronous();
            G.LongProcess();
            G.ShortProcess();

        // Asynchronous
        

            Asynchronous A = new Asynchronous();
            A.LongProcess();
            A.ShortProcess();
            }}}

         
    
 
    
 


