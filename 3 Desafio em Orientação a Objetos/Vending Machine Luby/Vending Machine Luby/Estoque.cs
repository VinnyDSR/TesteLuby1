using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine_Luby
{
    class Estoque
    {
        private int guarana = 4, mate = 5, coca = 7, nescafe = 3;

        public int Guarana { get => guarana; set => guarana = value; }
        public int Mate { get => mate; set => mate = value; }
        public int Coca { get => coca; set => coca = value; }
        public int Nescafe { get => nescafe; set => nescafe = value; }
    }
}
