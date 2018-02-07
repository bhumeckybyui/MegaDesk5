using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk
{
    class Desk
    {

        public String name;
        public double price;
        public float width;
        public float depth;
        public int drawers;
        public String surfaceType;
        public String rushOrder;

        public Desk(float width, float depth, int drawers, String surfaceType, String rushOrder, String name)
        {

            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceType = surfaceType;
            this.rushOrder = rushOrder;
            this.name = name;


        }


    }
}
