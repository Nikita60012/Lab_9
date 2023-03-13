using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Logins<string> logins = new Logins<string>(2);
            Passwords<string> passwords = new Passwords<string>(2);
            Console.WriteLine("Введите логин нового пользователя, для завершения ввода введите exit");
            string enter = Console.ReadLine();
            int count = 0;

            while (!enter.Equals("exit"))
            {
                logins.add(enter);
                Console.WriteLine("Введите пароль нового пользователя");
                enter = Console.ReadLine();
                passwords.add(enter);
                count++;
                if(count == logins.array.Length)
                {
                    Console.WriteLine("Массив заполнен");
                    break;
                }
                Console.WriteLine("Введите логин нового пользователя");
                enter = Console.ReadLine();
                
            }
            for(int i = 0; i < logins.array.Length; i++)
            {
                Console.WriteLine($"Логин: {logins.array[i]}; Пароль: {passwords.array[i]}");
            }
        }
        class UniverslaArray<Arr>
        {
            public Arr[] array;
            public UniverslaArray(params Arr[] array)
            {
                this.array = array;
            }
            public UniverslaArray(int size)
            {
                array = new Arr[size];
            }
            public string add(Arr addElement)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null)
                    {
                        array[i] = addElement;
                        return "Элемент успешно добавлен";
                    }
                }
                return "В массиве нет места";
            }
            public string add(int index, Arr addElement)
            {

                if (array[index] != null)
                {
                    array[index] = addElement;
                    return "Элемент успешно добавлен";
                }

                return "Такой позиции в массиве несуществует";
            }
            public string add(params Arr[] addElements)
            {

                array = addElements;

                return "Массив успешно добавлен";
            }
            public string remove(int index)
            {
                if (array[index] != null)
                {
                    array[index] = default;
                    return "Элемент успешно удалён";
                }
                return "Такого элемента не существует";
            }
            public string remove()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = default;
                }
                return "Массив успешно очищен";
            }
            public Arr getElement(int index)
            {
                if (array[index] != null)
                {
                    return array[index];
                }
                return default;
            }
            public int getLength()
            {
                return array.Length;
            }


        }
        class Logins<Arr> : UniverslaArray<Arr>
        {
            public Logins(int length)
            {
                array = new Arr[length];
            }
          
        }
        class Passwords<Arr> : UniverslaArray<Arr>
        {
            public Passwords(int length)
            {
                array = new Arr[length];
            }
        }
    }
}
