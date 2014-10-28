using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using PeopleServiceLib;
using System.Data;
using System.Data.Odbc;

namespace PeopleServiceLib
{
    public class PeopleService : IPeopleService
    {
        public List<Details> GetListOfPeople()
        {
            var details = new List<Details>();
            const string filename = @"C:\Users\Anabela\Documents\Visual Studio 2012\Projects\PeopleService\PeopleService\Details.csv";

            using (var reader = new StreamReader(filename))
            {
                string line;
                bool processedHeader = false;
                while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    if (!processedHeader)
                    {
                        processedHeader = true;
                        continue;
                    }

                    var columns = line.Split(',');

                    details.Add(new Details
                    {
                        ID = int.Parse(columns[0]),
                        Name = columns[1],
                        Country = columns[2],
                        Phone = columns[3],
                        Email = columns[4],
                    });
                }
            }

            return details;
        }

        public Details GetPerson(string name)
        {
            var people = GetListOfPeople();

            return people.FirstOrDefault(x => x.Name == name);
        }

        public string GetCountry(string country)
        {
            var csvFile = GetListOfPeople();

            return csvFile.FirstOrDefault(x => x.Country == country).Name;
        }

        public string GetName(string name)
        {
            var csvFile = GetListOfPeople();

            return csvFile.FirstOrDefault(x => x.Name == name).Country;

        }

    }

}
