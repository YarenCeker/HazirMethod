using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazırMetodlar
{
    class Program
    {
        public static void Main()
        {
            //string de bulunan cümlenin harflerini char array e atar
            string str = "SüperKahramanlar";
            char[] chars = str.ToCharArray();

            Console.WriteLine("String: " + str);
            Console.WriteLine("Character array :");

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(" " + chars[i]);
        
            }
            Console.WriteLine("\n");

            //büyük küçük harf duyarlılığı

            string str1 = "GeleceğiYazanKadınlar";
            string substr1 = "Yazan";
            string substr2 = "yazan";

            Console.WriteLine(str1.Contains(substr1));
            Console.WriteLine(str1.Contains(substr2));
            Console.WriteLine("\n");

            //string ile girilen cümlenin girilen kelime ile başlayıp başlamadığını denetler

            string kelime1 = "Kadınlar";
            if (str1.StartsWith(kelime1))
            {
                Console.WriteLine($"'{str1}' cümlesi {kelime1} kelimesi ile başlar.");
            }
            else
            {
                Console.WriteLine($"'{str1}' cümlesi {kelime1} kelimesi ile başlamaz.");
            }

            Console.WriteLine("\n");

            //string.Split methodu stringi parçalar

            string b = "Geleceği Yazan Kadınlar!!";

            char[] spearator = { ' ' };

            string[] strlist = b.Split(spearator);

            foreach (string s in strlist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");

            // herhangi bir sayıyla başarılı bir şekilde eşleşirse True döndürür, aksi takdirde False döndürür.

            bool result;
            char ch1 = '5';
            result = char.IsNumber(ch1);
            Console.WriteLine(result);
            char ch2 = 'c';
            result = char.IsNumber(ch2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
       
    }
    
}

