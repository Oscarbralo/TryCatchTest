using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchController.Interfaces;
using TryCatchDTOs;

namespace TryCatchController
{
    public class DeleteController : IDeleteController
    {
        readonly IHelperController _helper;

        public DeleteController()
        {
            _helper = new HelperController();
        }

        public string DeletePerson(string path, string phone)
        {
            List<PersonDTO> people = _helper.GetData(path, phone).ToList();
            _helper.WriteCsv(path, people);
            return string.Format("User with Phone = {0} deleted!", phone);
        }
    }
}
