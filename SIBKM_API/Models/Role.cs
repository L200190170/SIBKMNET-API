using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKM_API.Models
{
    public class Role
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
