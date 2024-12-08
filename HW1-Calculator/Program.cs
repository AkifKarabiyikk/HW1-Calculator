namespace HW1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*                                                  *\n*  HESAP MAKİNESİNE HOŞ GELDİNİZ !                 *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("* YAPMAK İSTEDİĞİNİZ İŞLEMİN OPERATÖRÜNÜ GİRİNİZ   *");
            Console.WriteLine("*                                                  *\n****************************************************");
            Console.WriteLine("*                                                  *\n* TOPLAMA == +                                     *");
            Console.WriteLine("*                                                  *\n* ÇIKARMA == -                                     *");
            Console.WriteLine("*                                                  *\n* ÇARPMA  == *                                     *");
            Console.WriteLine("*                                                  *\n* BÖLME   == /                                     *");
            Console.WriteLine("*                                                  *\n* MOD     == %                                     *");
            Console.WriteLine("*                                                  *\n****************************************************");

            char z;

            Console.Write("\n==> ");
            z = Convert.ToChar(Console.ReadLine());

            double x, y;

            Console.Write("İşlem yapılacak ilk sayıyı giriniz : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem yapılacak ikinci sayıyı giriniz : ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************************\n");

            if (z == '+')
            {
                Console.WriteLine(" {0} + {1} = {2} \n", x, y, x + y);
            }

            else if (z == '-')
            {
                Console.WriteLine(" {0} - {1} = {2} \n", x, y, x - y);

            }

            else if (z == '*')
            {
                Console.WriteLine(" {0} * {1} = {2} \n", x, y, x * y);

            }

            else if (z == '/')
            {
                Console.WriteLine(" {0} / {1} = {2:0.0000} \n", x, y, x / y);

            }

            else if (z == '%')
            {
                Console.WriteLine(" {0} mod {1} = {2} \n", x, y, x % y);

            }

            else
            {
                Console.WriteLine("YANLIŞ OPERATÖR SEÇİMİ YAPTINIZ!\n");
            }



        }
    }
}
