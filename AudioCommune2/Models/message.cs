using System;
namespace AudioCommune2.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Text { get; set; }

        //external
        public string UserID { get; set; }
        public int ServerID { get; set; }
    }
}
