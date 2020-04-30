using System;
using System.Xml.Linq;
using SoapService.Model;
using SoapService.Services.Interface;

namespace SoapService.Services
{
    public class SampleService: ISampleService
    {
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s;
        }
        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
        public Pessoa TestModel(Pessoa myPerson)
        {
            myPerson.Name += " SUCESSO";
            myPerson.Email += " SUCESSO";
            return myPerson;
        }
    }
}