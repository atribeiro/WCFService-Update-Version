using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientService.Models
{
    public class PeopleModelList : List<PeopleModel>
    {
        public int FromPortugal { 
            get {
                return this.Count(x => x.Country == "Portugal");
            }
        }
    }

    public class PeopleModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
