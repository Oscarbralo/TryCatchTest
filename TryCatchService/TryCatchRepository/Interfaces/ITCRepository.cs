using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchDTOs;

namespace TryCatchRepository.Interfaces
{
    public interface ITCRepository
    {
        IEnumerable<PersonDTO> ReadCSV(string path);

        IEnumerable<PersonDTO> ReadCSV(string path, string id);

        IEnumerable<PersonDTO> ReadCSV(string path, string name, string id);
    }
}
