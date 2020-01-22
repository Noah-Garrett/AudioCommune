using System;
namespace AudioCommune2.Models
{
    public class message
    {
        public int Id { get; set; }
        public string text { get; set; }

        //external
        public int userID { get; set; }
        public int serverID { get; set; }
    }
}
