using System;

namespace prg2._1_intro
{
    public class hw2
    {
        public void run()
        {
            //write all your code here!
            Console.WriteLine("Leapyear");
            int year = Convert.ToInt32(Console.ReadLine());
            for (int l = 0; l > 20 ; l++)
            {
                if (year %100 == 0)
                {
                    Console.WriteLine("Yes it is a Leapyear");
                }
                else if (year %400 == 0)
                {
                    Console.WriteLine("No this is not a Leapyear");
                }
                else if (year %4 == 0)
                {
                    Console.WriteLine("Yes it is a Leapyear");
                }
            }
        }

        public void stop()
        {
            //numberoftimes = 0;
        }
    }



}