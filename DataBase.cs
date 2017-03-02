using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testC
{
    /*!
\brief Родительский класс, не несущий никакой смысловой нагрузки

Данный класс имеет только одну простую цель: проиллюстрировать то,
как Doxygen документирует наследование 
*/
    static class DataBase
    {
        //question - то что ищем  
        public static string GetAnser(string question)
        {
            string path = "shop.txt";// путь к базе даных ):  

            // создаем обьект (читатель)  
            using (StreamReader sr =
                new StreamReader(path, Encoding.Default))
            {
                string str = null;
                while (true)
                {
                    //если пустая то это конец  
                    str = sr.ReadLine();
                    if (str != null)
                    {
                        //если считаная строчка   
                        //равна строке для поиска  
                        if (str == question)
                            return "есть в наличие.";
                    }
                    else
                        return "нет в наличие.";
                }
            }
        }
    }  
}
