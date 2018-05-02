using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    /*
     * ●	наименование носителя;
●	модель.
Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами: 
●	получение объема памяти;
●	копирование данных (файлов/папок) на устройство,
●	получение информации о свободном объеме памяти на устройстве;
●	получение общей/полной информации об устройстве.

*/
    public abstract class Storage
    {
        public int Count { get; set; } // колличество устройств
        public int Time { get; set; }

        protected string Name { get; set; }
        public string Model { get; protected set; }

        public abstract double GetMemory();

        public virtual void Copy()
        {
            Console.WriteLine("Copy start");
            Time = 2;
        }

  
        public abstract void PrintInfo();
    }
}
