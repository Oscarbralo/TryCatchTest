using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TryCatchDTOs;

namespace TryCatchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITCService
    {
        [OperationContract]
        IEnumerable<PersonDTO> CheckCSV(string path);

        [OperationContract]
        string AddPerson(string path, string name, string phone, string residence);

        [OperationContract]
        string DeletePerson(string path, string phone);

        [OperationContract]
        string UpdatePerson(string path, string name, string phone, string newName, string newPhone, string newResidence);
    }
}
