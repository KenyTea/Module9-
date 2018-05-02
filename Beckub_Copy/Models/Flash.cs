using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    /*Каждый носитель информации является объектом соответствующего класса: 
●	Flash-память — класс «Flash»;
●	класс DVD-диск — класс «DVD»;
●	класс съемный HDD — класс «HDD».
Все три класса являются производными от абстрактного класса «Носитель информации» — класс «Storage». Базовый класс («Storage») содержит следующие закрытые поля:
*/

        public enum TypeFlash { USB2, USB3}
    public class Flash : Storage
    {
        public int SpeedFlash { get; private set; }
        public int Memory { get; set; }
        public TypeFlash typeFlash {
            get
            {
                return typeFlash;
            }
            set
            {
                if (TypeFlash.USB2 == value)
                {
                    SpeedFlash = 2000;
                }
                else
                    SpeedFlash = 3000;
            }
        }

        public override double GetMemory()
        {
            return 0;
        }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
