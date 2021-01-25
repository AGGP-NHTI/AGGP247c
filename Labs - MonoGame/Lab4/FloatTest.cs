using System;

namespace FloatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new FloatTest(); 
        }
    }

    public class FloatTest
    { 
        public FloatTest()
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            bool check4 = false;

            float f1 = 1.0f / 3.0f;         // 1/3
            float f2 = (f1 * 3.0f)-1.0f;    // May not always turn up 0!
            float f3 = .333f;               // 1/3 typed out to 3 places
            float fzero = 0.0f;             // Zero, Literal 


            if (fzero == f2 )
            {   check1 = true; }

            if (NearlyEqual(f2, fzero))
            { check2 = true; }

            if (f1 == f3)
            { check3 = true; }

            if (NearlyEqual(f1, f3))
            { check4 = true; }
           
            Console.WriteLine("Float Check Application");

            Console.WriteLine("Check1: " + check1.ToString());
            Console.WriteLine("Check2: " + check2.ToString());
            Console.WriteLine("Check3: " + check3.ToString());
            Console.WriteLine("Check4: " + check4.ToString());


            Console.WriteLine("\nPress any Key");
            Console.ReadKey(); 
        }

        public bool NearlyEqual(float f1, float f2)
        {
            float check = f1 - f2; 
            return (Math.Abs(check) < 0.001); 
        }
    }
}
