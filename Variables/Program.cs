using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Логический тип");
            Console.WriteLine("Тип bool. Логический. 8 бит.");
            bool boolValue;
            boolValue = true; // = false;
            Console.WriteLine("Переменная boolValue: " + boolValue);
            Console.WriteLine("Допустимые значения TRUE или FALSE");
            
            Console.WriteLine(boolValue.GetType());

           
            Console.WriteLine("\nЦелочисленные типы");
            Console.WriteLine("\nТип byte. Беззнаковый. 8 бит");
            byte byteValue; // Объявление переменной
            byteValue = 214; // Инициализация переменной значением
            //byte byteValue = 115; // Инициализация в момент объявления
            //System.Byte byteValue = 14; // Объявление через полное имя структуры
            Console.WriteLine("Переменная byteValue: " + byteValue);
            Console.WriteLine($"Минимальное значение {Byte.MinValue}, Максимальное значение {Byte.MaxValue}");
            //byteValue = 500; // Значение может быть в диапазоне 0 - 255 (Ошибка)           
            

           
            Console.WriteLine("\nТип sbyte. Знаковый. 8 бит");
            sbyte sbyteValue = -12;
            Console.WriteLine("Переменная sbyteValue: {0}", sbyteValue);
            Console.WriteLine($"Минимальное значение {SByte.MinValue}, Максимальное значение {SByte.MaxValue}");
            

           
            Console.WriteLine("\nТип ushort. Беззнаковый. 16 бит");
            ushort ushortValue = 45183;
            Console.WriteLine("Переменная ushortValue: {0}", ushortValue);
            Console.WriteLine($"Минимальное значение {UInt16.MinValue}, Максимальное значение {UInt16.MaxValue}");
            

            
            Console.WriteLine("\nТип short. Знаковый. 16 бит");
            short shortValue = -16527;
            Console.WriteLine("Переменная shortValue: {0}", shortValue);
            Console.WriteLine($"Минимальное значение {Int16.MinValue}, Максимальное значение {Int16.MaxValue}");
            

            
            Console.WriteLine("\nТип uint. Беззнаковый. 32 бит");
            uint uintValue = 1000687;
            Console.WriteLine("Переменная uintValue: {0}", uintValue);
            Console.WriteLine($"Минимальное значение {UInt32.MinValue}, Максимальное значение {UInt32.MaxValue}");
            

            
            Console.WriteLine("\nТип int. Знаковый. 32 бит");
            int intValue = -856954;
            Console.WriteLine("Переменная intValue: {0}", intValue);
            Console.WriteLine($"Минимальное значение {Int32.MinValue}, Максимальное значение {Int32.MaxValue}");
            //intValue = 0b10; // Литерал "0b" для записи чилел в двоичной сислеме исчисления
            Console.WriteLine("Переменная intValue(binary): {0}", intValue);
            //intValue = 0x1f; // Литерал "0x" для записи чилел в шеснадцатиричной системе исчисления
            Console.WriteLine("Переменная intValue(HEX): {0}", intValue);
            string binaryIntStr = Convert.ToString(intValue, 2); 
            Console.WriteLine(binaryIntStr);
            

            
            Console.WriteLine("\nТип ulong. Беззнаковый. 64 бит");
            ulong ulongValue = 12365987000;
            Console.WriteLine("Переменная ulongValue: {0}", ulongValue);
            Console.WriteLine($"Минимальное значение {UInt64.MinValue}, Максимальное значение {UInt64.MaxValue}");
            

            
            Console.WriteLine("\nТип long. Знаковый. 64 бит");
            long longValue = -6589641000;
            Console.WriteLine("Переменная intValue: {0}", longValue);
            Console.WriteLine($"Минимальное значение {Int64.MinValue}, Максимальное значение {Int64.MaxValue}");
            

            
            Console.WriteLine("\nЧисла с плавающей точкой(запятой)");
            Console.WriteLine("\nТип float(Single). Знаковый. Точность 6-9 знаков. 32 бит");
            float floatValue = 7.86f; // Для инициализации значением типа float в конце значения добавляется "f" или "F"
            Console.WriteLine("Переменная floatValue: {0}", floatValue);
            Console.WriteLine($"Минимальное значение {Single.MinValue}, Максимальное значение {Single.MaxValue}");
           

            
            Console.WriteLine("\nТип double. Знаковый. Точность 15-17 знаков. 64 бит");
            double doubleValue = -14;
            Console.WriteLine("Переменная doubleValue: {0}", doubleValue);
            Console.WriteLine($"Минимальное значение {Double.MinValue}, Максимальное значение {Double.MaxValue}");
            

            
            Console.WriteLine("\nЧисла с фиксированной точкой(запятой)");
            Console.WriteLine("\nТип decimal. Знаковый. Точность 28-29 знаков. 128 бит");
            decimal decimalValue = 26.3m; // Для инициализации значением типа decimal в конце значения добавляется "m" или "M"
            Console.WriteLine("Переменная decimalValue: {0}", decimalValue);
            Console.WriteLine($"Минимальное значение {Decimal.MinValue}, Максимальное значение {Decimal.MaxValue}");



            Console.WriteLine("\nСимвольные типы");
            Console.WriteLine("\nТип char. 16 бит");
            char charValue = 'a';
            //Литерал "\x" - присвоение значения по коду ASCII
            //Литерал "\u" - присвоение значения по коду Unicode
            Console.WriteLine("Переменная charValue: {0}", charValue);          

            
            Console.WriteLine("\nТип string. Ссылочный тип. Размер ограничен 2Gb или размером оперативной памяти");
            string stringValue ="Some string";
            Console.WriteLine("Переменная stringValue: {0}", stringValue);

            //Не явное приведение типов

            uintValue = ushortValue;
            doubleValue = floatValue;

            //Явное приведение типов
            uintValue = (uint)shortValue;
            ushortValue = (ushort)intValue;

            Console.WriteLine(ushortValue);

            //Приобразование типов

            string strVal = "4.2";

            double intval = Double.Parse(strVal.Replace(".", ","));

            Console.WriteLine(intval);

            var someValue = "String Var";            
            
            Console.WriteLine(someValue.GetType());

            //Boxing/Unboxing

            object objectValue = "String Object";
            string strObj = (string)objectValue;
            

            Console.ReadLine();
        }
    }
}
