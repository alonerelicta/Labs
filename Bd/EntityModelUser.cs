using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LabaInformationTechologics.EntityModel
{
    [Table("Users")]
    public class EntityModelUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
       
        [Required]
        public String FIO { get; set; }
       
        [Required]
        public String Number { get;set; }
    
        [Required]
        public DateTime DateBirthDay { get; set; }
  
        [Required]
        public DateTime DateStart { get; set; }
        
    }
}
