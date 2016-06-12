using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Units;

namespace UV.Factories
{
    public class EnglishFactory : ScriptFactory
    {
        public override void MakeAndUnit(UVUnit unit, TextWriter writer)
        {
            writer.Write(" and ");
        }

        public override void MakeBeginGroupUnit(UVUnit unit, TextWriter writer)
        {
            writer.Write("(");
        }

        public override void MakeEndGroupUnit(UVUnit unit, TextWriter writer)
        {
            writer.Write(")");
        }

        public override void MakeNotNullUnit(UVUnit unit, TextWriter writer)
        {
            writer.Write($"{unit.ClientProperty} is not null");
        }

        public override void MakeOrUnit(UVUnit unit, TextWriter writer)
        {
            writer.Write(" or ");
        }
    }
}
