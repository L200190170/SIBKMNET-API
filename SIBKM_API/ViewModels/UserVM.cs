﻿using SIBKM_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
