#Repos of @YUDA, 6 June 2022  

static public void Main(string[] args)
        {
//===========================================================================================
            var numbers = new[] { 3, 7, 9, 2, 14, 6 }; // 6 Index 
            //Length
            Console.WriteLine("Length :" + numbers.Length);
//===========================================================================================
            //Index
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Length :" + index); // 5
//===========================================================================================
            //Clear 
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
//===========================================================================================
            //Copy Array
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var k in another)
            {
                Console.WriteLine(k);
            }
//===========================================================================================
            //Copy Manage
            Array.Sort(numbers);
            foreach (var l in numbers)
            {
                Console.WriteLine(l);
            }
//===========================================================================================
            //Reverse
            Array.Reverse(numbers);
            foreach (var m in numbers)
            {
                Console.WriteLine(m);
            }
//===========================================================================================
            //Value Max.Min.Sum
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
//===========================================================================================
            //Array Input
            int[] arr = new int[10]; 
            int i;  
               Console.Write("\n\nRead and Print elements of an array:\n");
               Console.Write("-----------------------------------------\n");	
               Console.Write("Input 10 elements in the array :\n");  
                        
                for(i=0; i<10; i++)  
                {  
                   Console.Write("element - {0} : ",i);
                   arr[i] = Convert.ToInt32(Console.ReadLine());  		
                }  

                   Console.Write("\nElements in array are: ");  
                   for(i=0; i<10; i++)  
                {  
                   Console.Write("{0}  ", arr[i]);  
                } 
                   Console.Write("\n"); 
//===========================================================================================
                // Check array if exist.
                string[] array = { "cat", "dot", "deves" };
                // Use Array.Exists in different ways.
                bool a = Array.Exists(array, element => element == "deves");
                bool b = Array.Exists(array, element => element == "python");
                bool c = Array.Exists(array, element => element.StartsWith("d"));
                bool d = Array.Exists(array, element => element.StartsWith("x"));

                // Display bools.       //Output
                Console.WriteLine(a);   //True
                Console.WriteLine(b);   //False
                Console.WriteLine(c);   //True
                Console.WriteLine(d);   //False
//===========================================================================================
                var myInts = new List<int>();
                    int tryConvert;
                    while (myInts.Count < 100)
                    {
                        Console.WriteLine("Enter a number not already in list: ");
                        var userEntry = Console.ReadLine();
                        if (int.TryParse(userEntry, out tryConvert))
                        {
                            // if WAS able to convert to a number, now check if in the list
                            if (myInts.Contains(tryConvert))
                                Console.WriteLine("Number already in list");
                            else
                                myInts.Add(tryConvert);
                        }
                        else
                        {
                            // allow user to enter a "Q" to quit vs adding all 100 entries
                            if (userEntry == "Q")
                                break;

                            Console.WriteLine("Not a valid number");
                        }
                    }
