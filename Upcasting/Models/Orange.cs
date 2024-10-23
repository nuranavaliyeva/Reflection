using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC {  get; set; }

        public override void Taste()
        {
            Console.WriteLine("portagal dadi");
        }
    }
}
