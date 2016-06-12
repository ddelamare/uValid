using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public class AndUnit : OperatorUnit
    {
        public override void Generate(ScriptFactory factory, TextWriter tw)
        {
            factory.MakeAndUnit(this, tw);
        }
    }
}
