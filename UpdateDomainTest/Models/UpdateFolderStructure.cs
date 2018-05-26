using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UpdateDomainTest.Models
{
    [Serializable]        
    public class Folders
    {
        
        public List<Folder> Folder
        {
            get; set;
        }
    }


    [Serializable]    
    public class Folder
    {
        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public string Over;

        //[XmlArray("Folders")]
        //public Folders Folders { get; set; }
    }


}
