using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchController.Interfaces
{
    public interface ICreateController
    {
        string AddNewPerson(string path, string name, string phone, string residence);
    }
}
