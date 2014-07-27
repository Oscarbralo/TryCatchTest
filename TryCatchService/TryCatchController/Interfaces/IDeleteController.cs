using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchController.Interfaces
{
    public interface IDeleteController
    {
        string DeletePerson(string path, string phone);
    }
}
