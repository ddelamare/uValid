using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public class OrUnit : OperatorUnit
    {
        public override void Generate(ScriptFactory factory, TextWriter tw)
        {
            factory.MakeOrUnit(this, tw);
        }
    }
}
