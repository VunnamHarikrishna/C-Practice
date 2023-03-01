using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
         /*1*/   byte by = 49;//this is byte it can store  0-255 number 
            Byte By = 4;
            Console.WriteLine(by+" "+By);
         /*2*/short sh =(short) (by + by);//short sh =(short) by; we can store directly bu lower data can not add and store
            Int16 Sh =(Int16)by;
            Console.WriteLine(sh+" "+Sh);
         /*3*/  int itn =sh;//
            Int32 Itn = itn;
         /*4*/ char ch = (char)188;
            Char Ch = 'r';
            Console.WriteLine(ch+" "+Ch);
            itn = ch;
           Console.WriteLine($"{itn:0.00} {Itn}");
          /*5*/  float fl = 14.344878454534534f;
            float Fl= 14.344878454534534f;
            Console.WriteLine($"{fl:0.00}  {Fl}");
            Console.WriteLine(fl);
           /*6*/double db =14.254915424554521556;//13 positions
            Double Db= 4.254915424554521556; 
            Console.WriteLine($"{db} Db");
            /*7*/ long lo=4484848645454534;
            UInt64 Lo = 4484848645454534;
            Console.WriteLine(lo+" "+Lo);
            /*8*/bool bo=true;
            bool Bo = false;
            Console.WriteLine(bo+" "+Bo);
            //-------decimal 
            decimal dc = 8554324187676876897686611234m;
            Decimal Dc = 8554324187676876897686611234m;
            Console.WriteLine(dc+" "+Dc);
            //// signed 
            sbyte sby = (sbyte)by;// we don't store directly a value
            SByte SBy= (SByte)by; 
            Console.WriteLine(sby+" "+SBy);
            //////////////////////////un signed///////////////////////////////////////////////////////
            ushort ush = (ushort)sh;//
            UInt16 Ush=(UInt16) ush;
            Console.WriteLine(ush+" "+ Ush);
            uint uin = ush;//
            UInt32 Uin = 32;
            Console.WriteLine(uin+" "+Uin);
            ulong ulo = 8241234567897822122l;
            UInt64 Ulo= 8241234567897822122l;
            Console.WriteLine(ulo+" "+Ulo);
            string str = "hari";
            String Str = "hi";
            Console.WriteLine(str+" "+Str);
            DateTime dt;
           
            Console.WriteLine($"{{{{{{{str}}}}}}} {Str}");

            Console.ReadLine();

        }
    }
}
