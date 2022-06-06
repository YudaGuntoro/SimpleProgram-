        static public void Main(string[] args)
        {
            /*  Add();
              AddRange();
              Remove();
              RemoveAt();
              IndexOf();
              Constains();
              Count();
            */
            
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.Write("Index of 1:" + numbers.IndexOf(1));
            Console.Write("Index of 1:" + numbers.LastIndexOf(1));
        }
