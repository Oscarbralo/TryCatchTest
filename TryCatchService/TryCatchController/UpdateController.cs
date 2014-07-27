using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchController.Interfaces;
using TryCatchDTOs;

namespace TryCatchController
{
    public class UpdateController : IUpdateController
    {
        readonly IHelperController _helper;

        public UpdateController()
        {
            _helper = new HelperController();
        }

        public string UpdatePerson(string path, string name, string phone, string newName, string newPhone, string newResidence)
        {
            List<PersonDTO> people = _helper.GetData(path, name, phone).ToList();
            foreach (PersonDTO person in people)
            {
                if (!string.IsNullOrEmpty(newName))
                {
                    person.Name = newName;
                }
                if (!string.IsNullOrEmpty(newPhone))
                {
                    person.Phone = newPhone;
                }
                if (!string.IsNullOrEmpty(newResidence))
                {
                    person.Residence = newResidence;
                }
            }
            _helper.WriteCsv(path, people);
            return string.Format("User with Name = {0} and Phone = {1} updated!", name, phone);
        }
    }
}
