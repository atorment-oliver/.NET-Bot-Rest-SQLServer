using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class User
    {
        public string microsite { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public Country country { get; set; }
        public bool active { get; set; }
        public bool newsletter { get; set; }
        public Agency agency { get; set; }
        public bool b2c { get; set; }
        public IList<string> roles { get; set; }
        public IList<ProviderConfig> providerConfigs { get; set; }
        public string referralId { get; set; }
    }
}
