using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    internal class Program
    {
        //// ---------------------------ham ve hinh vuong
        //public static void Rectangle(int hangs, int cots, char icon)
        //{
        //    for (int i = 0; i < hangs; i++)
        //    {
        //        for (int j = 0; j < cots; j++)
        //        {
        //            Console.Write(icon);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        ////---------------------------Ham ve hinh tam giac
        //public static void SquareTriangle(int kichCo, char icon)
        //{
        //    for (int i = 0; i <= kichCo; i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            Console.WriteLine(icon);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        ////---------------------------ham ve hinh tam giac can
        //public static void IsoscelesTriandle(int kichCo, char icon)
        //{
        //    for (int i = 0; i <= kichCo; i++)
        //    {
        //        for (int j = 0; j <= kichCo - i - 1; j++)
        //        {
        //            Console.WriteLine(" ");
        //        }
        //        for (int k = 0; k <= i * 2; k++)
        //        {
        //            Console.WriteLine(icon);
        //        }
        //        Console.WriteLine();

        //    }
        //}
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                //------------Hien Thi cac lua chon-----------------
                Console.WriteLine("*********************MENU**************************");
                Console.WriteLine("1. Draw the Rectangle");
                Console.WriteLine("2. Draw the Square Triangle");
                Console.WriteLine("3. Draw the Isosceles Triandle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("***************************************************");
                //------------Nhap lua chon ban muon ve---------------
                Console.Write("Nhap hinh ban muon ve: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Draw the Rectangle");
                        //--------------- Nhap So Hang, so cot va bieu Tuong ----------------------
                        Console.Write("Nhap So Hang: ");
                        int hangs = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap So Cot: ");
                        int cots = Int32.Parse(Console.ReadLine());
                        Console.Write("Bieu tuong ban muon ve la: ");
                        char icon = char.Parse(Console.ReadLine());

                        //------goi ham ve hinh vuong
                        //Rectangle(hangs, cots, icon);

                        for (int i = 0; i < hangs; i++)
                        {
                            for (int j = 0; j < cots; j++)
                            {
                                Console.Write(icon);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("2. Draw the Square Triangle");
                        //----------------- Nhap Kich co va nhap bieu tuong -------------------------
                        Console.Write("Nhap kich co ban mun ve: ");
                        int kichCo = Int32.Parse(Console.ReadLine());
                        Console.Write("Bieu tuong ban muon ve la: ");
                        icon = char.Parse(Console.ReadLine());

                        //-----goi ham ve hinh tam giac
                        //SquareTriangle(kichCo, icon);

                        for (int i = 0; i <= kichCo; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(icon);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("3. Draw the Isosceles Triandle");
                        //----------------- Nhap Kich co va nhap bieu tuong -------------------------
                        Console.Write("Nhap kich co ban mun ve: ");
                        kichCo = Int32.Parse(Console.ReadLine());
                        Console.Write("Bieu tuong ban muon ve la: ");
                        icon = char.Parse(Console.ReadLine());

                        //------goi ham ve hinh tam giac can
                        //IsoscelesTriandle(kichCo, icon);


                        for (int i = 0; i <= kichCo; i++)
                        {
                            for (int j = 0; j <= kichCo - i - 1; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k <= i * 2; k++)
                            {
                                Console.Write(icon);
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 0:
                        Environment.ExitCode = 0;
                        break;
                    default:
                        Console.WriteLine("Hay nhap lua chon cua ban");
                        break;

                }

                Console.WriteLine();
            }
            
        }
    }
}
