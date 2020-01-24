using System;
namespace AudioCommune2.Models
{
    public class playlist
    {
        public int Position { get; set; }

        //external
        public int ServerID {get; set;}
        public int VideoID { get; set; }
        public int UserID { get; set; }
    }
}
