namespace ASPNET_Core_final_project.Data.Models.ViewModels
{
    public class ProgrammerVM
    {
        public string FullName { get; set; }
        public DateTime? DateLeave { get; set; }

        public List<uint> LanguagesIds { get; set; }
    }
}
