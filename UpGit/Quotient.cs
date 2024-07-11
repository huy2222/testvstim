using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap vao 2 so a va b: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int quotient = a / b;
            Console.WriteLine("Ket qua chia lay nguyen cua a va b la: " + quotient);
        }
    }
}
