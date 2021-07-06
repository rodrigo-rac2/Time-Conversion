using System;

namespace Time_Conversion
{
    class Result
    {
        public static string timeConversion(string s)
        {
            int hr;
            string hrstr;
            if (isMorning(s))
            {
                hr = Int32.Parse(s.Substring(0, 2));
                if (hr == 12)
                    hrstr = "00";
                else if (hr < 10)
                    hrstr = "0" + hr;
                else
                    hrstr = hr + "";
            }
            else
            {
                hr = Int32.Parse(s.Substring(0, 2));
                hrstr = hr == 12 ? hr + "" : (hr + 12) + "";
            }
            return (hrstr + s.Substring(2, 6));
        }

        // time will follow the format 00:00:00AM
        public static bool isMorning(string time)
        {
            return time.Substring(8).Equals("AM");
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);
//            textWriter.WriteLine(result);
//            textWriter.Flush();
//            textWriter.Close();
        }
    }

}
