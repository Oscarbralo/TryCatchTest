using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchDTOs;

namespace TryCatchController.Interfaces
{
    public interface IReadController
    {
        IEnumerable<PersonDTO> GetPeople(string path);
    }
}
