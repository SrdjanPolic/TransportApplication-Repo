

using Repository.ModelBase;

namespace DBLayerPOC.Infrastructure.Login
{
    public class LoginModel : Entity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsInactive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
