using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Pomazal
{
     class Desk
    {
        public int deskWidth { get; set; }
        public int deskHeight { get; set;}
        public int numDrawers { get; set; }
        public string custName { get; set; }
        public int surfaceArea { get; set; }
        public string customerName { get; internal set; }

        public enum surfaceMaterial
        {
            oak = 200,
            laminate = 100,
            pine = 50,
            rosewood = 300,
            veneer = 150,
        }

    }
}
