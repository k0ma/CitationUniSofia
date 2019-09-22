namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;

    public class AuthorInstitution : BaseModel<int>
    {
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int InstitutionId { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
