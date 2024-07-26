﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }
    }
}
