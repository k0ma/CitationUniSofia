namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;

    public class PublicationFieldScience : BaseModel<int>
    {
        public int Sequence { get; set; }

        public int PublicationId { get; set; }
        public Publication Publication { get; set; }

        public int FieldScienceId { get; set; }
        public FieldScience FieldScience { get; set; }
    }
}
