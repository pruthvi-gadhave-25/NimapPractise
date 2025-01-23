using EcomMvc.Models;

namespace EcomMvc.Helper.Interface
{
    public interface IHelper
    {
        public string IssueToken(LoginViewModel user);
    }
}
