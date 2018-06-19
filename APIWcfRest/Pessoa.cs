using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace APIWcfRest
{
    [DataContract,Serializable]
    public class Pessoa
    {
        
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public int Idade { get; set; }
        [DataMember]
        public DateTime DataNascimento { get; set; }
        
    }
}
