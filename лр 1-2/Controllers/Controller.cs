using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabaInformationTechologics.Bd;
using LabaInformationTechologics.Mappers;
using LabaInformationTechologics.BuisnesModels;
using System.Windows.Forms;
namespace LabaInformationTechologics.Controllers
{
    public class ControllerUser
    {
        private BD _Bd;
        
        public ControllerUser(BD bd)
        {
            _Bd = bd;
        }
        public List<EntityModel.EntityModelUser> getAll()
        {

            List<EntityModel.EntityModelUser> users = _Bd.User.ToList();
            return users;
        }
        public void Add(EntityModel.EntityModelUser user)
        {
            _Bd.User.Add(user);
            _Bd.SaveChanges();
        }
        public void Delete(int id)
        {
            var user = _Bd.User.Where(x => x.Id == id).FirstOrDefault();
            _Bd.Remove(user);
            _Bd.SaveChanges();
        }
    }
}
