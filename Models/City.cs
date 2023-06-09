﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class City
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\nCity: {this.Description}";
        }

    }
}
