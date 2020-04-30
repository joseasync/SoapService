using System.ServiceModel;
using SoapService.Model;

namespace SoapService.Services.Interface
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        Pessoa TestModel(Pessoa myPerson);
    }
}
