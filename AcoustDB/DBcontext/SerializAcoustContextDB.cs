using SaveConfigObject;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DBcontext
{
    [Serializable]
    public class SerializAcoustContextDB : ObjectClassSettings
    {
        [XmlElement("SAcoustContextDB")]
        public AcoustContextDB SAcoustContextDB { get; set; }

        public override void PostLoad()
        {

        }

        protected override void Reset()
        {
            SAcoustContextDB = new AcoustContextDB();
        }
    }
}
