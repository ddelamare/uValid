using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;
namespace UV.Units
{
    public class NotNullUnit : UVUnit
    {

        public NotNullUnit(string clientPropertyName, string serverPropertyName)
        {
            this._clientPropertyName = clientPropertyName;
            this._serverPropertyName = serverPropertyName;
        }

        public override void Generate(ScriptFactory factory, TextWriter tw)
        {
            factory.MakeNotNullUnit(this, tw);
        }

        public override bool Validate(object model)
        {
            return GetPropertyByName(model, ServerProperty) != null;
        }
    }
}
