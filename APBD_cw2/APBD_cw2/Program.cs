using APBD_cw2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace APBD_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 3)
            {
                Console.WriteLine("Niewystarczajace parametry");
            }

            var filePath = args[0];
            var outputPath = args[1];


            var students = new HashSet<Student>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var split = line.Split(",");
                if (split.Length != 9)
                {

                }
                students.Add(new Student
                {
                    id = $"s{split[4]}",
                    imie = split[0],
                    lastName = split[1],
                    tryb = split[2],
                    studia = split[3],
                    email = split[6],
                    mothersName = split[7],
                    fathersName = split[8],
                    birthDate = DateTime.Parse(split[5]).ToShortDateString(),
                });
            }

            Console.WriteLine(students.Count);
            Console.WriteLine(outputPath);

            using (StreamWriter sw = new StreamWriter(outputPath))
            {
                Console.WriteLine("halo? ");
                XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>),
                                       new XmlRootAttribute("uczelnia"));
                serializer.Serialize(sw, students);
                serializer.Serialize(sw, students);

                sw.Write("dupa nie marudz");
                sw.Flush();
            }
        }
    }
}
