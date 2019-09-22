namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;

    public class PublicationAreaScience : BaseModel<int>
    {
        public int Sequence { get; set; }

        public int PublicationId { get; set; }
        public virtual Publication Publication { get; set; }

        public int AreaScienceId { get; set; }
        public virtual AreaScience AreaScience { get; set; }
    }
}
