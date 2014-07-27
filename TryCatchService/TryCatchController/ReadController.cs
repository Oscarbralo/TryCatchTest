using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchController.Interfaces;
using TryCatchDTOs;
using TryCatchRepository;
using TryCatchRepository.Interfaces;

namespace TryCatchController
{
    public class ReadController : IReadController
    {
        readonly IHelperController _helper;

        public ReadController()
        {
            _helper = new HelperController();
        }

        public IEnumerable<PersonDTO> GetPeople(string path)
        {
            return _helper.GetData(path);
        }
    }
}
