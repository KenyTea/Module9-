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
    public class HDD : Storage
    {
        public int SpeedHDD { get; set; }
        public TypeDevice typeDevice { get; set; }
        public int  Claster { get; set; }
        public int ClasterMomory { get; set; }

        public override double GetMemory()
        {
            return ClasterMomory;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
        }
    }
}
