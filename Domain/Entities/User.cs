using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

}
