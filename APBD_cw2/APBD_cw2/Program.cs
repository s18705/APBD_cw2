using APBD_cw2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

namespace APBD_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
//
                if (args.Length != 3)
                {
                    Console.WriteLine("Niewystarczajace parametry");
                }

                var filePath = args[0];
                var outputPath = args[1];
                var format = args[2];

                var students = new HashSet<Student>();
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var split = line.Split(",");
                    if (split.Length != 9)
                    {
                        return;
                    }

                    students.Add(new Student
                    {
                        id = $"s{split[4]}",
                        imie = split[0],
                        nazwisko = split[1],
                        tryb = split[2],
                        studia = split[3],
                        email = split[6],
                        imieMatki = split[7],
                        imieOjca = split[8],
                        dataUrodzenia = DateTime.Parse(split[5]).ToShortDateString(),
                    });
                }

                Console.WriteLine(students.Count);
                Console.WriteLine(outputPath);

                using (StreamWriter streamWriter = new StreamWriter(outputPath))
                {
                    switch (format)
                    {
                        case "xml":
                            Console.WriteLine("halo? ");
                            XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>),
                                                   new XmlRootAttribute("uczelnia"));
                            serializer.Serialize(streamWriter, students);
                            //serializer.Serialize(streamWriter, students);

                            //streamWriter.Write("dupa nie marudz");
                            // streamWriter.Flush();

                            break;

                        case "json":
                            var toJson = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                            streamWriter.Write(toJson);
                            break;

                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
