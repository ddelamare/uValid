using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public abstract class UVUnit
    {    
        protected string _serverPropertyName;
        protected string _clientPropertyName;
        protected string _clientScript;

        public abstract void Generate(ScriptFactory factory, TextWriter tw);
        public abstract bool Validate(object argument = null);
        public virtual string ClientProperty
        {
            get { return _clientPropertyName; } 
        }
        public virtual string ServerProperty
        {
            get { return _serverPropertyName; }
        }

        protected virtual dynamic GetPropertyByName(object model, string name)
        {
            if (model == null)
                return null;
            // Look for a property that matches the name
            PropertyInfo property = model.GetType().GetProperty(name);

            if (property != null)
            {
                return property.GetValue(model);
            }

            // Check public and private fields
            //FieldInfo field = model.GetType().GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            //if (field != null)
            //{
            //    return field.GetValue(model);
            //}

            // Possible room for desperate searching

            throw new Exception("Could not find matching field or property");
        }


    }
}
