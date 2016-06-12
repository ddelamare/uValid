using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public class GroupUnit : OperatorUnit
    {
        bool _isBeginGroup;
        public GroupUnit(bool isBeginGroup)
        {
            _isBeginGroup = isBeginGroup;
        }


        public override void Generate(ScriptFactory factory, TextWriter tw)
        {
            if (_isBeginGroup)
            {
                factory.MakeBeginGroupUnit(this, tw);
            }
            else
            {
                factory.MakeEndGroupUnit(this, tw);
            }
        }
    }
}
