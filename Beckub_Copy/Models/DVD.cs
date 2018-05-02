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
    public enum TypeDVD { Oneside, TwoSide }
    public class DVD : Storage
    {
        public int SpeedWrite { get; set; }
        public int SpeedRead { get; set; }
        public TypeDVD typeDVD { get; set; }

        public DVD(string name)
        {
            base.Name = name;
            base.Model = "gfdkfl;k";
        }

        public override double GetMemory()
        {
            if (TypeDVD.Oneside == typeDVD)
                return 4.7;
            else
                return 9.4;
        }

        public override void Copy()
        {
            // base.Copy();
        }

        public override void PrintInfo()
        {

        }

    }

}
