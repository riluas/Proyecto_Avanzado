namespace RatePI.Models
{
    internal class MySqlConnection
    {
        private string connString;

        public MySqlConnection(string connString)
        {
            this.connString = connString;
        }
    }
}