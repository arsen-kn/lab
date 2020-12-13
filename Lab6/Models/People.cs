using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20, ErrorMessage = "Name length should be less then 20 characters")]
        public string FirstName { get; set; }
        [MinLength(2)]
        [MaxLength(20, ErrorMessage = "Name length should be less then 20 characters")]
        public string LastName { get; set; }
       
        public int FlatId { get; set; }
    }
}
