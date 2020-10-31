using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBD_cw2.Models
{
    public class Student
    {
        [XmlAttribute(attributeName: "email")]
        public string email { get; set; }
        [XmlAttribute(attributeName: "firstname")]
        public string imie { get; set; }
        [XmlAttribute(attributeName: "Studies")]
        public string lastName { get; set; }
        [XmlAttribute(attributeName: "tryb")]
        public string tryb { get; set; }
        [XmlAttribute(attributeName: "id")]
        public string id { get; set; }
        [XmlAttribute(attributeName: "mothersname")]
        public string mothersName { get; set; }
        [XmlAttribute(attributeName: "fathersname")]
        public string fathersName { get; set; }
        public string birthDate { get; set; }
        public string studia { get; set; }
    }
}
