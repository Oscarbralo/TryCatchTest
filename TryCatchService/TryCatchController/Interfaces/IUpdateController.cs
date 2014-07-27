using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchController.Interfaces
{
    public interface IUpdateController
    {
        string UpdatePerson(string path, string name, string phone, string newName, string newPhone, string newResidence);
    }
}
