using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaInformationTechologics
{
    public class Filtr
    {
        
        public List<BuisnesModels.BuisnesModelUser> AddFilter(BindingList<BuisnesModels.BuisnesModelUser> Users, DateTime dateAfter, DateTime dateBefore, int ageStart, int ageEnd)
        {
            if (Users == null)
            {
                MessageBox.Show("список пользователей пуст");
                return Users.ToList();
            }
            else
            {
               
                if (ageStart == 0 && ageEnd == 0)
                {
                    return Users.Where(c => c.DateStart >= dateAfter && c.DateStart <= dateBefore).ToList();
                }
                else if(dateAfter == dateBefore && dateAfter == DateTime.Now.Date)
                {
                    MessageBox.Show("create");
                    return Users.Where(c =>c.GetAge() >= ageStart && c.GetAge() <= ageEnd).ToList();
                }
                else
                {
                    return Users.Where(c => c.GetAge() >= ageStart && c.GetAge() <= ageEnd && c.DateStart >= dateAfter && c.DateStart <= dateBefore).ToList();
                }
                
            }
        }
    }
}
