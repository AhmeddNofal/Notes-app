using System.ComponentModel.DataAnnotations.Schema;

namespace notesApp1.Models
{
    public class Note
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Note()
        {

        }
    }
}
