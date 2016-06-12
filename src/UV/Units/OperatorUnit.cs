using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public abstract class OperatorUnit : UVUnit
    {

        public override bool Validate(object argument)
        {
            // Operators can't be invalid
            return true;
        }
    }
}
