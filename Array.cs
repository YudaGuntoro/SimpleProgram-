  static public void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 }; // 6 Index 

            //Length
            Console.WriteLine("Length :" + numbers.Length);

            //Index
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Length :" + index); // 5

            //Clear 
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy Array
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var k in another)
            {
                Console.WriteLine(k);
            }
            
            //Copy Manage
            Array.Sort(numbers);
            foreach (var l in numbers)
            {
                Console.WriteLine(l);
            }

            //Reverse
            Array.Reverse(numbers);
            foreach (var m in numbers)
            {
                Console.WriteLine(m);
            }

            //Value Max.Min.Sum
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
}
