using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PeopleServiceLib
{

    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]


    public interface IPeopleService
    {
        [OperationContract]
        string GetName(string name);
        [OperationContract]
        string GetCountry(string country);
        [OperationContract]
        Details GetPerson(string name);
        [OperationContract]
        List<Details> GetListOfPeople();
    }
}
