using System;
namespace AudioCommune2.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }

        //external
        public int UserID { get; set; }
        public int ServerID { get; set; }
    }
}
