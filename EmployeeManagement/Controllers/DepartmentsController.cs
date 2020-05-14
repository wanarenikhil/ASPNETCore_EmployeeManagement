 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class DepartmentsController : Controller
    {
        public string List()
        {
            return "Departmetns list action";
        }

        public string Details()
        {
            return "Departmetns Details action";
        }
    }
}