using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_Winforms_Devexpress.Models
{
    public class Client
    {
    
        public Guid ClientId { get; set; }
        public string ContactName{get;set;}
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
