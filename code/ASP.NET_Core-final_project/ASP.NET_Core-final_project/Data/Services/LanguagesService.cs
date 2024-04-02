using ASPNET_Core_final_project.Data.Models;
using ASPNET_Core_final_project.Data.Models.ViewModels;

namespace ASPNET_Core_final_project.Data.Services
{
    public class LanguagesService
    {
        private AppDbContext _context;

        public LanguagesService(AppDbContext context)
        {
            _context = context;
        }

        public void AddLanguage(LanguageVM language)
        {
            var _language = new Language()
            {
                Name = language.Name
            };

            _context.Languages.Add(_language);
            _context.SaveChanges();

            
            foreach (var id in language.ProgrammerIds)
            {
                var _programmer_language = new Programmer_Language()
                {
                    ProgrammerId = id,
                    LanguageId = _language.Id
                };

                _context.Programmer_Languages.Add(_programmer_language);
                _context.SaveChanges();
            }
            
        }

        public void UpdateLanguage(uint id, LanguageVM language)
        {
            var _language = _context.Languages.FirstOrDefault(n => n.Id == id);

            if(language != null) 
            {
                _language.Name = language.Name;

                _context.SaveChanges();
            }
        }

        public List<Language> GetLanguages() => _context.Languages.ToList();

        public void RemoveLanguage(uint id)
        {
            var _language = _context.Languages.FirstOrDefault(n => n.Id == id);

            if(_language != null)
            {
                _context.Languages.Remove(_language);
                _context.SaveChanges();
            }
        }
    }
}
