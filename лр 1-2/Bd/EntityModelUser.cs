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
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("ФИО")]
        [Required]
        public String FIO { get; set; }
        [Column("Номер зачетной книжки")]
        [Required]
        public String Number { get;set; }
        [Column("Дата рождения")]
        [Required]
        public DateTime DateBirthDay { get; set; }
        [Column("Дата Поступления")]
        [Required]
        public DateTime DateStart { get; set; }
        
    }
}
