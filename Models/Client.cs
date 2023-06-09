﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return $"\nId: {this.Id}\nName: {this.Name}\nPhone: {this.Phone}\n" +
                $"Address: {this.Address}\nRegister Date: {this.RegisterDate}";
        }
    }
