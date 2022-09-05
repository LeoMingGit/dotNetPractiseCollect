using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest.model
{
    [Table("T_Users")]
    public class User
    {
        public  long ID { get; set; }

        public string JobTitle { get; set; }    

        public  string EmailAddress { get; set; }

        public string FirstNameLastName { get; set; }

        public string Newcolumn { get; set; }

    }
}
