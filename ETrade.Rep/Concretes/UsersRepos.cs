using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETrade.Rep.Concretes
{
    public class UsersRepos : BaseRepository<Users>, IUsersRepos
    {
       
        public UsersRepos(Context context) : base(context)
        {
          
        }

        public Users Login(Users user)
        {
            var u = new Users();
            try
            {
                var loginUser = Set().Where(x => x.UserName == user.UserName).FirstOrDefault();
                bool verified = BCrypt.Net.BCrypt.Verify(user.Password, loginUser.Password);
                if (verified)
                {
                    return loginUser;
                }
                else { return u; }
               
            }
            catch (Exception)
            {
               
                return u;
            } 
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(Users user)
        {
            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);  
                user.CreatedDate = DateTime.Now;
                user.LastUpdated   = DateTime.Now;  
                Add(user);
                
                return true;    
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
