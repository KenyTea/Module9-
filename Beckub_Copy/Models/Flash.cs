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

        public enum TypeDevice { USB2, USB3}
    public class Flash : Storage
    {
        public int SpeedFlash { get; private set; }
        public double MemoryFlash { get; set; }
        public TypeDevice typeDevice {
            get
            {
                return typeDevice;
            }
            set
            {
                if (TypeDevice.USB2 == value)
                {
                    SpeedFlash = 2000;
                }
                else
                    SpeedFlash = 3000;
            }
        }

        public override double GetMemory()
        {
            return MemoryFlash;
        }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }

        
    }
}
