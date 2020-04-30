using System.Runtime.Serialization;
using System.ServiceModel;

namespace SoapService.Model
{
    [DataContract]
    public class Pessoa
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

    }
}
