using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchDTOs;

namespace TryCatchController.Interfaces
{
    internal interface IHelperController
    {
        IEnumerable<PersonDTO> GetData(string path);

        IEnumerable<PersonDTO> GetData(string path, string phone);

        IEnumerable<PersonDTO> GetData(string path, string name, string phone);

        void WriteCsv(string path, IEnumerable<PersonDTO> people);
    }
}
