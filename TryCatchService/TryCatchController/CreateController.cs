using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchController.Interfaces;
using TryCatchDTOs;

namespace TryCatchController
{
    public class CreateController : ICreateController
    {
        readonly IHelperController _helper;

        public CreateController()
        {
            _helper = new HelperController();
        }

        public string AddNewPerson(string path, string name, string phone, string residence)
        {
            List<PersonDTO> people = _helper.GetData(path).ToList();
            people.Add(new PersonDTO()
            {
                Name = name,
                Phone = phone,
                Residence = residence
            });
            _helper.WriteCsv(path, people);
            return string.Format("{0}, with Phone = {1}, and living in {2} added!", name, phone, residence);
        }
    }
}
