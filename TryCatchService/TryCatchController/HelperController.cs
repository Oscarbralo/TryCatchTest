using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchController.Interfaces;
using TryCatchDTOs;
using TryCatchRepository;
using TryCatchRepository.Interfaces;

namespace TryCatchController
{
    internal class HelperController : IHelperController
    {
        readonly ITCRepository _repository;

        public HelperController()
        {
            _repository = new TCRepository();
        }

        public IEnumerable<PersonDTO> GetData(string path)
        {
            return _repository.ReadCSV(path).ToList();
        }

        public IEnumerable<PersonDTO> GetData(string path, string phone)
        {
            return _repository.ReadCSV(path, phone).ToList();
        }

        public IEnumerable<PersonDTO> GetData(string path, string name, string phone)
        {
            return _repository.ReadCSV(path, name, phone).ToList();
        }

        public void WriteCsv(string path, IEnumerable<PersonDTO> people)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (PersonDTO p in people)
                {
                    streamWriter.WriteLine(string.Format("{0},{1},{2}", p.Name, p.Phone, p.Residence));
                }
            }
        }
    }
}
