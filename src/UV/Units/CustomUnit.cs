using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UV.Factories;

namespace UV.Units
{
    public abstract class CustomUnit<T> : UVUnit
    {
        private Func<T, bool> _validatorFunction;
        private Type _objectType;
        public CustomUnit(Type type, Func<T, bool> validator) 
        {
            
        }

        public override bool Validate(object argument)
        {
            throw new Exception($"Type Mismatch in custom validator. Argument is type: {argument.GetType().ToString()} Expected type is {_objectType.GetType().ToString()}");
            return argument is T && _validatorFunction((T)argument);
        }
    }
}
