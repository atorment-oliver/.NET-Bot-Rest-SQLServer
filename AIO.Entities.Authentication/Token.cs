namespace AIO.Entities.Authentication
{
    public class Token
    {
        private string _token;
        public string token
        {
            get { return _token; }
            set { _token = value; }
        }

        private string _expirationInSeconds;
        public string expirationInSeconds
        {
            get { return _expirationInSeconds; }
            set { _expirationInSeconds = value; }
        }
    }
}
