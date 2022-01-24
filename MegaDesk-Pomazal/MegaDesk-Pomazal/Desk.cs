using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Pomazal
{
     class Desk
    {
        public int? deskWidth { get; set; }
        public int? deskHeight { get; set;}
        public int? numDrawers { get; set; }
        public string custName { get; set; }
        public int? surfaceArea { 
            get { 
                return deskHeight * deskWidth; 
            } 
        }
        

        public surfaceMaterial selectedSurfaceMaterial { get; set; }

        public enum surfaceMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 150,
        }

    }
}
