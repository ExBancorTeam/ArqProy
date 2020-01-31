using System;
using System.Collections.Generic;
using System.Text;

namespace ArqProy.Models.Clients
{
    public class Contact
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Client Client { get; set; }
    }
}
