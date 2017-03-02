using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testC
{
    /*!
	\brief Родительский класс, не несущий никакой смысловой нагрузки
    nhjkjkjjkjkjkj
     1
     2
     2
     
     4
     
	Данный класс имеет только одну простую цель: проиллюстрировать то,
	как Doxygen документирует наследование 
*/
    class Controller
    {
        public string Question(string msg)//msg - то что ищем  
        {
            Model model = new Model();
            return "На даный момент у нас товар "
                + model.GetAnser(msg);
        }
    }
}
