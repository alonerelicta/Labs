
using LabaInformationTechologics.Bd;
using LabaInformationTechologics.EntityModel;

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
        public void Add(EntityModelUser user)
        {
            user.Id = 0;
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
