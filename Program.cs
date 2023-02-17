using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RadencyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(StringChecker.Check("radency", "rdnc", "aey"));


            Console.ReadLine();
        }
    }
    public class StringChecker
    {
        public static bool Check(string s, string p1, string p2)
        {

            do
            {
                char a = s[0];
                if (p1.Length != 0)
                {
                    char b = p1[0];
                    if (a == b)
                    {
                        s = s.Remove(0, 1);
                        p1 = p1.Remove(0, 1);
                    }
                    else
                    {

                        if (p2.Length != 0)
                        {
                            char c = p2[0];
                            if (a == c)
                            {
                                s = s.Remove(0, 1);
                                p2 = p2.Remove(0, 1);
                            }
                            else
                                return false;
                        }



                    }
                }
                else
                {
                    if (p2.Length != 0)
                    {
                        char c = p2[0];
                        if (a == c)
                        {
                            s = s.Remove(0, 1);
                            p2 = p2.Remove(0, 1);
                        }
                        else
                        { return false; }
                    }
                }
            }
            while (s.Length > 0);

            return true;





        }
    }
}