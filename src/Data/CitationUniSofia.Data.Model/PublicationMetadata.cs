namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;

    public class PublicationMetadata : BaseModel<int>
    {
        public int Sequence { get; set; }

        public int PublicationId { get; set; }
        public virtual Publication Publication { get; set; }

        public int MetadataId { get; set; }
        public virtual Metadata Metadata { get; set; }
    }
}

