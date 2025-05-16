using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
   public class UserRepository
    {
        private string filePath = "users.text";

        public void SaveToFilePath(User user) {

            string msg = $"{user.Name} , {user.Email}";
            File.AppendAllText(filePath, msg);

        }

    }
}
