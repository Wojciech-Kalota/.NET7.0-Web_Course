namespace ASPNET_Core_final_project.Data.Models
{
    public class Language
    {
        public uint Id { get; set; }
        public string Name { get; set; }

        //public uint ProgrammerId { get; set; }
        //public Programmer Programmer { get; set; }
        public List<Programmer_Language> Programmer_Language { get; set; }
    }
}
