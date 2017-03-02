using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testC
{/*!
	\brief Модель, не несущий никакой смысловой нагрузки

	Данный класс имеет только одну простую цель: проиллюстрировать то,
	как Doxygen документирует наследование 
*/
    class Model
    {
        //question - то что ищем  
        public string GetAnser(string question)
        {
            return DataBase.GetAnser(question);
        }

    }
}
