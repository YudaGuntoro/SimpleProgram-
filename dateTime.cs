Repos @Yuda 8 June 2022;    
dateTime : 
            var dataTime = new DateTime(2015, 2, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(dataTime);

            Console.WriteLine("Hour :{0} , Minute:{1} , Sec : {2}", now.Hour, now.Minute, now.Second);

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            
            Console.WriteLine(tommorow);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());  //Wednesday, June 8, 2022
            Console.WriteLine(now.ToShortDateString()); //6/8/2022
            Console.WriteLine(now.ToLongTimeString());  //10:43:47 AM 
            Console.WriteLine(now.ToShortTimeString()); //10:43 AM 
            Console.WriteLine(now.ToString("U"));
            
//=========================================================================================================
TimeSpan : 
             //Create
            var timeSpan = new TimeSpan(2, 2, 2);
            Console.WriteLine(timeSpan);
            var timeSpan1 = TimeSpan.FromHours(2);
            Console.WriteLine(timeSpan1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            //Property
            Console.Write("Minutes ; {0}", timeSpan.Minutes);               // Minutes; 2
            Console.Write("Total Minutes : {0}", timeSpan.TotalMinutes);    // Total Minutes : 122.03333333333333

            //add
            Console.WriteLine("Add Example : " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Parse 
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));
