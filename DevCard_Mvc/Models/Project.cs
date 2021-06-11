using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set;  }
        public string Description { get; set;  }
        public string Client { get; set;  }

    }
}
