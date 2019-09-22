namespace CitationUniSofia.Data.Model
{
    using CitationUniSofia.Data.Common;
    using System.Collections.Generic;

    public class AreaScience : BaseModel<int>
    {
        public AreaScience()
        {
            this.PublicationsAreasScience = new HashSet<PublicationAreaScience>();
        }

        public string Name { get; set; }

        public int? FieldScienceId { get; set; }
        public virtual FieldScience FieldScience { get; set; }


        public ICollection<PublicationAreaScience> PublicationsAreasScience { get; set; }
    }
}
