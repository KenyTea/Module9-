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
    }
}
