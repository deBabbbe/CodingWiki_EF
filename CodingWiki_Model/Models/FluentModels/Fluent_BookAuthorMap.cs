namespace CodingWiki_Model.Models
{
    public class Fluent_BookAuthorMap
    {
        public virtual int Book_Id { get; set; }
        public virtual int Author_Id { get; set; }

        public virtual Fluent_Book Book { get; set; }
        public virtual Fluent_Author Author { get; set; }
    }
}
