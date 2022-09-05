// Дописать реализацию методов class myArray

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingLab001
{
    class CommandLine
    {
        public static int[] Numbers;
        public static int[] GetNumbers()
        {
            return Numbers;
        }

        public static void AddNumbers(int _number, int _index)
        {
            Numbers[_index] = _number;
        }
        public static void DetectNumbers(string[] _args)
        {
            try
            {
                int _length = _args.Length;
                bool IsInputNeed = true;
                for (int i = 0; i < _length; i++)
                {
                    Console.Write("Аргумент {1} = {0}", _args[i], i);
                    Converter.Convert2Int(_args[i], out int _Number, out bool _succes);
                    if (_succes)
                    {
                        Console.Write(" - это число {0}", _Number);
                    }
                    else
                    {
                        Converter.Convert2Int(_args[i], IsInputNeed, out _Number);
                        _args[i] = _Number.ToString();
                        AddNumbers(_Number, i);
                        Console.WriteLine("Получили число {0}", _Number);
                    }
                    Console.WriteLine();
                }
                foreach (var item in _args)
                {
                    Console.WriteLine("Получено число {0}", item);
                }
            }
            catch
            {
                Console.WriteLine("Программа требует ввода агрументов командной строки");

            }
        }
    }
    class Converter
    {
        public static void Convert2Int(string _input, out int result, out bool _succes)
        {
            try
            {
                result = int.Parse(_input);
                _succes = true;
            }
            catch
            {
                result = 0;
                _succes = false;
            }
        }
        public static void Convert2Int(string _input, bool IsInputNeed, out int result)
        {
            bool IsConverted = false;
            if (IsInputNeed)
            {
                try
                {
                    result = int.Parse(_input);
                }
                catch
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Введите число");
                            result = int.Parse(Console.ReadLine());
                            IsConverted = true;
                        }
                        catch
                        {
                            Console.WriteLine("Не число, повторите ввод...");
                            result = 0;
                        }

                    } while (!IsConverted);
                }
            }
            else
            {
                Convert2Int(_input, out result, out bool _success);
            }

        }
    }

    class myArray
    {
        public void Print(int[] _Arr)
        {
            for (int i = 0; i < _Arr.Length; i++)
            {

                Console.WriteLine(_Arr[i]);
            }
        }
        public void Print(string[] _Arr)
        {
            for (int i = 0; i < _Arr.Length; i++)
            {

                Console.WriteLine(_Arr[i]);
            }
        }
        public void Sort(int[] _Arr)
        {

        }
        public void Sort(string[] _Arr)
        {

        }
        public void FindEven(int[] _Arr)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myArray ar = new myArray();
            ar.Print(CommandLine.AddNumbers(_number, _index));
            CommandLine.AddNumbers(_number, _number);
            /*try
            {
                string[] _args = new string[args.Length];
                int[] _intArgs = new int[args.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    _args[i] = args[i];
                }
                CommandLine.DetectNumbers(_args);
                _intArgs = CommandLine.GetNumbers();

            }
            catch
            {
                Console.WriteLine("Программа требует ввода агрументов командной строки");
            }*/
        }
    }
}

