namespace PrevencionSalud.Welcome.BLL.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PrevencionSalud.Welcome.Contract;

    public class UserService : IUSerService
    {
        public void Create(UserContract contract)
        {
            throw new NotImplementedException();
        }

        public void Update(UserContract contract)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserContract contract)
        {
            throw new NotImplementedException();
        }

        public IList<UserContract> Search(string queryString)
        {
            return new List<UserContract>();
            throw new NotImplementedException();
        }

        public UserContract Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
