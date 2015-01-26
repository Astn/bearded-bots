using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleHost
{
    public class Env
    {
        public BlockType Type { get; set; }

    }

    public enum BlockType
    {
        Empty=0,
        Solid=1;
        Water=2;

    }
}
