using System;
using System.Runtime.InteropServices;

class programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string a = Console.ReadLine();
        string r = ChangeCase(a);
        Console.WriteLine(r);

        static string ChangeCase(string a)
        {
            char[] f = a.ToCharArray();
            for (int i = 0; i < f.Length; i++)
            {
                if (i % 2 == 0)
                {
                    f[i] = char.ToUpper(f[i]);
                }
                else
                {
                    f[i] = char.ToLower(f[i]);
                }
            }
            return new string(f);
        }
    }
}