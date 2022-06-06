     static public void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[5] { 1, 3, 5, 1, 3 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            arr[2] = new int[2] { 2, 4 };

            Console.WriteLine(arr.Length);

            for (int i = 0; i < arr.Length; i++) // Show how many Length of Index (3) 
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++) // Value of Each Range 
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : ""); //If Section
                }
            }
         }
