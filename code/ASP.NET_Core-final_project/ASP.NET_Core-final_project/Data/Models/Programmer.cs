namespace ASPNET_Core_final_project.Data.Models
{
    public class Programmer
    {
        public uint Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime? DateLeave { get; set; }

        //public uint LanguageId { get; set; }
        //public Language Language { get; set; }
        public List<Programmer_Language> Programmer_Language { get; set; }
       

    }
}
