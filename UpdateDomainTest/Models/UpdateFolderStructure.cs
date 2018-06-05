﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UpdateDomainTest.Models
{
    [Serializable]   
    [XmlRoot("list")]     
    public class FoldersConn
    {
        
        [XmlArray("folders"), XmlArrayItem("folder")]
        public Folder[] Folders
        {
            get; set;
        }
    }


    [Serializable]
    [XmlRoot("folder")]
    public class Folder
    {
        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public string Over;

        [XmlArray("folders"), XmlArrayItem("folder")]
        public Folder[] Folders { get; set; }
    }


}
