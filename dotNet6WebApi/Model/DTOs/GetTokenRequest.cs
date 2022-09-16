using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs
{
    public class GetTokenRequest
    {

        [Required]
        public string usercode { get; set; }

        [Required]
        public string pwd { get; set; }
    }
}
