﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeelo.Entities.POCOs
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DataCreate { get; set; } = DateTime.Now;
    }
}
