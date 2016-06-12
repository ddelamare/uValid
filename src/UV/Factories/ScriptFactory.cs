using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UV.Collections;
using UV.Units;

namespace UV.Factories
{
    public abstract class ScriptFactory
    {

        //private string _seperator = " ";

        //public string Seperator
        //{
        //    get
        //    {
        //        return _seperator;
        //    }

        //    set
        //    {
        //        _seperator = value;
        //    }
        //}

        public ScriptFactory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public string Generate(UVExpression units)
        //{
        //    var writer = new StringWriter();
        //    bool success = Generate(units, writer);
        //    return writer.ToString();
        //}

        //public override bool Generate(UVExpression units, TextWriter writer)
        //{
        //    bool wasWritten = false; 
        //    foreach (var unit in units.Units)
        //    {
        //        MakeUnitStringBase(unit, writer);
        //        wasWritten = true;
        //    }
        //    return wasWritten;
        //}    

        //private void MakeUnitStringBase(UVUnit unit,TextWriter writer)
        //{
        //    // Do all fancy unit stuff here for all stock 
        //    //TODO: Fancy stuff. Like deciding which generator function to call
        //    if (unit is NotNullUnit)
        //    {
        //        MakeNotNullUnit(unit, writer);
        //    }
        //    if (unit is AndUnit)
        //    {
        //        MakeAndUnit(unit, writer);
        //    }
        //    writer.Write(Seperator);
        //}


        public abstract void MakeAndUnit(UVUnit unit, TextWriter writer);
        public abstract void MakeOrUnit(UVUnit unit, TextWriter writer);
        public abstract void MakeNotNullUnit(UVUnit unit, TextWriter writer);
        public abstract void MakeBeginGroupUnit(UVUnit unit, TextWriter writer);
        public abstract void MakeEndGroupUnit(UVUnit unit, TextWriter writer);


    }
}
