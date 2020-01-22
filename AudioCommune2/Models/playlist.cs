using System;
namespace AudioCommune2.Models
{
    public class playlist
    {
        public int position { get; set; }

        //external
        public int serverID {get; set;}
        public int videoID { get; set; }
        public int userID { get; set; }
    }
}
