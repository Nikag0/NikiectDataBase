using SaveConfigObject;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DBcontext
{
    [Serializable]
    public class SerializCompletedData : ObjectClassSettings
    {
        [XmlElement("SAllStageObj")]
        public List<AllStageObj> SAllStageObj { get; set; }

        public override void PostLoad()
        {

        }

        protected override void Reset()
        {
            SAllStageObj = new List<AllStageObj>();
        }
    }
}
