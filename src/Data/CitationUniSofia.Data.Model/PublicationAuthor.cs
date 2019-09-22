namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;

    public class PublicationAuthor : BaseModel<int>
    {
        public int PublicationId { get; set; }
        public virtual Publication Publication { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}