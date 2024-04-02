namespace ASPNET_Core_final_project.Data.Models
{
    public class Programmer_Language
    {
        public uint Id { get; set; }
        public uint ProgrammerId { get; set; }
        public Programmer Programmer { get; set; }
        public uint LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
