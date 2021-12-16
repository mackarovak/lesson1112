using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1112
{
    [BuildingInfo("Нурмухаметов Руслан Ринатович", "Суварстроит")]
    class Building
    {
        private int index;
        private double Height;
        private int Storeys;
        private int Apartments;
        private int Entrances;

        static int index1 = 0;

        public Building()
        {
            index = index1++;
        }

        public Building(int index, double Height, int Storeys, int Apartments, int Entrances)
        {
            this.index = index;
            this.Height = Height;
            this.Storeys = Storeys;
            this.Apartments = Apartments;
            this.Entrances = Entrances;
        }
    }
}
