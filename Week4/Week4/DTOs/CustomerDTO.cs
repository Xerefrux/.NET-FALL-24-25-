using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4.DTOs
{
    public class CustomerDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public System.DateTime DateJoined { get; set; }


    }
}