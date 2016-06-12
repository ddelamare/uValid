using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;
using UV.Units;

namespace UV.Collections
{
    public class UVExpression
    {
        Queue<UVUnit> _unitQueue;
        List<UVUnit> _invalidUnits;

        public UVExpression()
        {
            _unitQueue = new Queue<UVUnit>();
            _invalidUnits = new List<UVUnit>();
        }

        public Queue<UVUnit> Units
        {
            get
            {
                return _unitQueue;
            }
        }

        public UVExpression And()
        {
            Units.Enqueue(new AndUnit());
            return this;
        }

        public UVExpression IsNotNull(string sharedPropertyName)
        {
            Units.Enqueue(new NotNullUnit(sharedPropertyName, sharedPropertyName));
            return this;
        }

        public UVExpression IsNotNull(string clientPropertyName, string serverPropertyName)
        {
            Units.Enqueue(new NotNullUnit(clientPropertyName, serverPropertyName));
            return this;
        }

        public UVExpression BeginGrouping()
        {
            Units.Enqueue(new GroupUnit(true));
            return this;
        }

        public UVExpression EndGrouping()
        {
            Units.Enqueue(new GroupUnit(false));
            return this;
        }

        public UVExpression Or()
        {
            Units.Enqueue(new OrUnit());
            return this;
        }

        public string Generate(ScriptFactory factory)
        {
            var tw = new StringWriter();
            Generate(factory, tw);
            return tw.ToString();
        }

        public void Generate(ScriptFactory factory, TextWriter tw)
        {
            foreach (var unit in _unitQueue)
            {
                unit.Generate(factory, tw);
            }
        }

        public bool Validate(object model)
        {
            bool allValid = true;
            _invalidUnits.Clear();
            foreach (var unit in _unitQueue)
            {
                if (!unit.Validate(model))
                {
                    allValid = false;
                    _invalidUnits.Add(unit);
                }
            }
            return allValid;
        }

    }
}
