﻿using System;

namespace pr1_2
{
    /* class Program
     {

     static void Main(string[] args)
         {
             //создание переменных и объявление массивов
             SByte a = 0; Byte b = 0; Int16 c = 0;
             Int32 d = 0; Int64 e = 0; string s = "";
             Exception ex = new Exception();
             object[] types = { a, b, c, d, e, s, ex };
             //запуск циклов 
             foreach (object o in types)
             {
                 string type;
                 if (o.GetType().IsValueType) type = "Value type";
                 else
                     type = "Reference Type";
                 Console.WriteLine("{0}: {1}", o.GetType(), type);
             }
         }
     }*/
    class Program
    {

        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2 Application Development Foundation";
            string[] sa = s.Split(" ");
            s = string.Join(" ", sa); Console.WriteLine(s);
        }
    }
}
