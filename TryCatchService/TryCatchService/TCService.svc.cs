using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TryCatchController;
using TryCatchController.Interfaces;
using TryCatchDTOs;

namespace TryCatchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TCService : ITCService
    {
        readonly IReadController _controller;
        readonly ICreateController _addController;
        readonly IDeleteController _deleteController;
        readonly IUpdateController _updateController;

        public TCService()
        {
            _controller = new ReadController();
            _addController = new CreateController();
            _deleteController = new DeleteController();
            _updateController = new UpdateController();
        }

        public IEnumerable<PersonDTO> CheckCSV(string path)
        {
            try
            {
                IEnumerable<PersonDTO> people = _controller.GetPeople(path);
                return people;
            }
            catch
            {
                return new List<PersonDTO>();
            }
        }

        public string AddPerson(string path, string name, string phone, string residence)
        {
            try
            {
                return _addController.AddNewPerson(path, name, phone, residence);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeletePerson(string path, string phone)
        {
            try
            {
                return _deleteController.DeletePerson(path, phone);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdatePerson(string path, string name, string phone, string newName, string newPhone, string newResidence)
        {
            try
            {
                return _updateController.UpdatePerson(path, name, phone, newName, newPhone, newResidence);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
