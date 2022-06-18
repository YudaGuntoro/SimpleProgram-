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
//======================================================================================================
   var sentence = "bla bli blu ble blo bla bla bla bla bla";
          const int maxLength = 10;

          if (sentence.Length < maxLength)                //Jika Kalimat kurang dari max then write
              Console.WriteLine(sentence);                

          var words = sentence.Split(' ');                //Split Space menjadi blabliblu 

          /*string data1 = words[0];
          string data2 = words[1];
          string data3 = words[2];
          */    
          //Console.Write(data1); Console.Write(data2); Console.WriteLine(data3);

          var totalCharacter = 0;
          var summaryWords = new List<string>();

          foreach (var word in words)
          {
              summaryWords.Add(word);                 // Menambahkan value word kedalam summary words 
              totalCharacter += word.Length;      

              if (totalCharacter > maxLength)
              {
                  break;
              }
          }
          var summary = String.Join(" ", summaryWords) + "...";  // Menggabubgkan hasil Spasi dan summary word +  . . .  (bla bli blu...)
          Console.WriteLine(summary);

//======================================================================================================

var uniques = GetUniqueNumbers(numbers);
public static List<int> GetUniqueNumbers(List<int>numbers)
{
        var uniques = new List<int>();
        foreach( var number in numbers)
        {
                if (!uniques.Contains(number))
                        uniques.Add(number);
        }
        
        return uniques;
}


//======================================================================================================
 List<string> numbersStrLst = new List<string>
            { 
                "One", 
                "Two",
                "Three",
                "Four",
                "Five"
            };

            foreach (string a in numbersStrLst)   // Menurun
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(String.Join(", ", numbersStrLst)); // Menyamping
            Console.WriteLine(numbersStrLst[0]);
        
