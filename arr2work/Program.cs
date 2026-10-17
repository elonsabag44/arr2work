namespace mesima1array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            targil5();
        }
        static void targil1()
        {
            int[] arr = new int[50];
                    var myArrayLibary = new ArrayLibrary.MyArrayLibary(); // Corrected namespace spelling
            object value = myArrayLibary.InputArray(arr);

        }
        static void targil2()
        {

            int[] grades = new int[10];
            Console.WriteLine("insert 10 numbers:");
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }


            double avg = Avrage(grades);
            Console.WriteLine("Average: " + avg);


            distancformavrage(grades, avg);
        }


        static double Avrage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }


        static void distancformavrage(int[] arr, double avrage)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                double distanc = arr[i] - avrage;
                double absoulotdistanc = Math.Abs(distanc);
                Console.WriteLine("Grade: " + arr[i] + " | Distance: " + absoulotdistanc);
            }
        }
        static void targil3()
        {
            char[] reasults = new char[15];
            char[] gusses = new char[15];
            int count = 0;
            Console.WriteLine("insert 15 reasults");
            Console.WriteLine("insert 15 gusses");
            for (int i = 0; i < reasults.Length; i++)
            {
                reasults[i] = char.Parse(Console.ReadLine());
                gusses[i] = char.Parse(Console.ReadLine());
                if (gusses[i] == reasults[i])
                {
                    count++;
                }
            }
            Console.WriteLine("the corect answers are:" + count);
        }
        static void Targil4()
        {
            int[] n = new int[20];
            int[] m = new int[60];
            Console.WriteLine("insert 60 nums");
            Random random = new Random();



            for (int i = 0; i < m.Length; i++)
            {
                int randomnum = random.Next(1, 61);
                int num = int.Parse(Console.ReadLine());
                if (m[i + 2] == 1)
                {
                    n[i] = m[i] + m[i + 1];


                }
                else if (m[i + 2] == 2)
                {
                    n[i] = m[i] - m[i + 1];
                }
                else if (m[i + 2] == 3)
                {
                    n[i] = m[i] * m[i + 1];
                }
                else if (m[i + 2] == 4)
                {
                    n[i] = m[i] / m[i + 1];
                }


            }
            Console.WriteLine(n[n.Length]);

        }
        static void targil5()
        {
            int[] intnums = new int[40];
            Console.WriteLine("insert nums if u want to stop just prees -1");
            int num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                int sum = 0;

                for (int i = 0; i < intnums.Length; i++)
                {
                    sum += intnums[i];
                    if (num == intnums[i] || num < intnums[i])
                    {

                        Console.WriteLine($"placement {intnums[i]}");
                        Console.WriteLine($"sum of evrything tli the placment {sum}");
                        bool found = true;

                    }
                }

                num = int.Parse(Console.ReadLine());
            }
        }

        static void targil6()
        {
            Console.WriteLine("hey welcome which seat r you want to seat");
            bool[] seat = new bool[200];
            for (int i = 0; i < seat.Length; i++)
            {
                Console.Write("which seat do u want " + i + " -  (1-200): ");
                int requestedSeat = int.Parse(Console.ReadLine());
                int finalSeat = GetNearestSeat(seat, requestedSeat);


                Console.WriteLine("מוזמן מספר " + i + " קיבל את מקום: " + finalSeat);
                Console.WriteLine();
            }
        }
        static int GetNearestSeat(bool[] seats, int requested)
        {

            if (!seats[requested])
            {
                seats[requested] = true;
                return requested;
            }

            int offset = 1;
            int foundSeat = -1;
            bool found = false;

            while (!found)
            {
                int seatBelow = requested - offset;
                int seatAbove = requested + offset;

                if (seatBelow >= 1 && !seats[seatBelow])
                {
                    foundSeat = seatBelow;
                    found = true;
                }
                else if (seatAbove <= 200 && !seats[seatAbove])
                {
                    foundSeat = seatAbove;
                    found = true;
                }
                else
                {
                    offset++;
                }
            }

            seats[foundSeat] = true;
            return foundSeat;
        }
        static void targil7()
        {
            // 1. הגדרת שני המערכים עבור 31 ימים בכל חודש
            int[] july = new int[31];
            int[] august = new int[31];

            int sumJuly = 0;
            int sumAugust = 0;

            // 2. קליטת הניתוקים לחודש יולי וחישוב הסכום
            Console.WriteLine("הכנס את מספר הניתוקים לכל יום בחודש יולי (31 ימים):");
            for (int i = 0; i < july.Length; i++)
            {
                Console.Write("יולי - יום " + (i + 1) + ": ");
                july[i] = int.Parse(Console.ReadLine());
                sumJuly += july[i]; // צבירת הסכום
            }

            // 3. קליטת הניתוקים לחודש אוגוסט וחישוב הסכום
            Console.WriteLine("\nהכנס את מספר הניתוקים לכל יום בחודש אוגוסט (31 ימים):");
            for (int i = 0; i < august.Length; i++)
            {
                Console.Write("אוגוסט - יום " + (i + 1) + ": ");
                august[i] = int.Parse(Console.ReadLine());
                sumAugust += august[i]; // צבירת הסכום
            }

            // 4. חישוב הממוצעים (חיוני להשתמש ב-31.0 כדי לקבל שבר בלתי מוגבל)
            double avgJuly = sumJuly / 31.0;
            double avgAugust = sumAugust / 31.0;

            Console.WriteLine("\nממוצע ניתוקים ביולי: " + avgJuly);
            Console.WriteLine("ממוצע ניתוקים באוגוסט: " + avgAugust);

            // 5. בדיקה האם חל שיפור של 25% לפחות
            // שיפור של 25% פירושו שממוצע אוגוסט קטן/שווה ל-75% מממוצע יולי
            if (avgAugust <= avgJuly * 0.75)
            {
                Console.WriteLine("\nחל שיפור משמעותי באיכות הקו!");
            }
            else
            {
                Console.WriteLine("\nלא חל שיפור משמעותי באיכות הקו.");
            }
        }
    }
}







