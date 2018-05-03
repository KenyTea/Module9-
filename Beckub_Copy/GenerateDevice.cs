﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beckub_Copy.Models;

namespace Beckub_Copy
{
    public class GenerateDevice
    {
        public GenerateDevice()
        {
            hdd = new List<HDD>();
            dvd = new List<DVD>();
            flash = new List<Flash>();
        }
        public List<HDD> hdd { get; set; }
        public List<DVD> dvd { get; set; }
        public List<Flash> flash { get; set; }
        private Random rand = new Random();
        public void GenarateFlash()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                Flash f = new Flash(string.Format("Model # {0}", rand.Next()));
                f.MemoryFlash = rand.Next(2000, 128000);
                f.typeDevice = (TypeDevice)rand.Next(0, 1);
                flash.Add(f);
            }
        }
    }
}
