using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace APBD_cw2.Models
{
    public class Student
    {
        [XmlAttribute(attributeName: "Email")]
        public string email { get; set; }

        [XmlAttribute(attributeName: "Imie")]
        public string imie { get; set; }

        [XmlAttribute(attributeName: "Nazwisko")]
        public string nazwisko { get; set; }

        [XmlAttribute(attributeName: "Tryb")]
        public string tryb { get; set; }

        [XmlAttribute(attributeName: "Id")]
        public string id { get; set; }

        [XmlAttribute(attributeName: "Imie_Matki")]
        public string imieMatki { get; set; }

        [XmlAttribute(attributeName: "Imie_Ojca")]
        public string imieOjca { get; set; }

        [XmlAttribute(attributeName: "Data_urodzenia")]
        public string dataUrodzenia { get; set; }

        [XmlAttribute(attributeName: "Studia")]
        public string studia { get; set; }
    }
}
