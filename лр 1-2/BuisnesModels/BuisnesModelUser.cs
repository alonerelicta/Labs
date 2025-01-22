using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaInformationTechologics.BuisnesModels
{
    public class BuisnesModelUser
    {
        
        public  int Id { get; set; }
       
        public String FIO { get; set; }
       
        public String Number { get; set; }
       
        public DateTime DateBirthDay { get; set; }
       
        public DateTime DateStart { get; set; }
      
        public BuisnesModelUser(int Id, String FIO, String Number, DateTime BirthDay, DateTime DateStart)
        {
            this.Id = Id;
            this.FIO = FIO;
            this.Number = Number;
            this.DateBirthDay = BirthDay;
            this.DateStart = DateStart;
        }
        public BuisnesModelUser() { }
        public int GetAge()
        {
            return DateTime.Now.Year - DateBirthDay.Year;
        }

    }
}
