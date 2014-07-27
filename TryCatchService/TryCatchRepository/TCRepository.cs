using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchDTOs;
using TryCatchRepository.Interfaces;

namespace TryCatchRepository
{
    public class TCRepository : ITCRepository
    {
        public IEnumerable<PersonDTO> ReadCSV(string path)
        {
            List<PersonDTO> people = new List<PersonDTO>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = string.Empty;
                while (!string.IsNullOrEmpty(line = streamReader.ReadLine()))
                {
                    string[] lineSplitted = line.Split(',');
                    people.Add(new PersonDTO()
                    {
                        Name = lineSplitted[0],
                        Phone = lineSplitted[1],
                        Residence = lineSplitted[2]
                    });
                }
            }
            return people;
        }

        public IEnumerable<PersonDTO> ReadCSV(string path, string phone)
        {
            List<PersonDTO> people = new List<PersonDTO>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = string.Empty;
                while (!string.IsNullOrEmpty(line = streamReader.ReadLine()))
                {
                    string[] lineSplitted = line.Split(',');
                    people.Add(new PersonDTO()
                    {
                        Name = lineSplitted[0],
                        Phone = lineSplitted[1],
                        Residence = lineSplitted[2]
                    });
                }
            }
            return people.Where(x => x.Phone != phone);
        }

        public IEnumerable<PersonDTO> ReadCSV(string path, string name, string phone)
        {
            List<PersonDTO> people = new List<PersonDTO>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = string.Empty;
                while (!string.IsNullOrEmpty(line = streamReader.ReadLine()))
                {
                    string[] lineSplitted = line.Split(',');
                    people.Add(new PersonDTO()
                    {
                        Name = lineSplitted[0],
                        Phone = lineSplitted[1],
                        Residence = lineSplitted[2]
                    });
                }
            }
            return people.Where(x => x.Name == name && x.Phone == phone);
        }
    }
}
