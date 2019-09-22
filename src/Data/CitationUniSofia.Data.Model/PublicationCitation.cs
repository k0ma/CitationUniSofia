namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class PublicationCitation
    {
        [Key]
        public int Id { get; set; }

        public int Sequence { get; set; }

        public int PublicationId { get; set; }
        public virtual Publication Publication { get; set; }

        public int CitationId { get; set; }
        public virtual Citation Citation { get; set; }
    }
}
