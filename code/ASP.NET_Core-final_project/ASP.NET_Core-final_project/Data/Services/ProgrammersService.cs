using ASPNET_Core_final_project.Data.Models;
using ASPNET_Core_final_project.Data.Models.ViewModels;

namespace ASPNET_Core_final_project.Data.Services
{
    public class ProgrammersService
    {
        private AppDbContext _context;

        public ProgrammersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProgrammer(ProgrammerVM programmer)
        {
            var _programmer = new Programmer()
            {
                FullName = programmer.FullName,
                DateJoin = DateTime.Now,
                DateLeave = programmer.DateLeave
            };

            _context.Programmers.Add(_programmer);
            _context.SaveChanges();
            
            foreach (var id in programmer.LanguagesIds)
            {
                var _programmer_language = new Programmer_Language()
                {
                    ProgrammerId = _programmer.Id,
                    LanguageId = id
                };

                _context.Programmer_Languages.Add(_programmer_language);
                _context.SaveChanges();
            }
            
        }

        public void UpdateProgrammer(uint bookID, ProgrammerVM programmer)
        {
            var _programmer = _context.Programmers.FirstOrDefault(n => n.Id == bookID);

            if(_programmer != null) 
            {
                _programmer.FullName = programmer.FullName;
                _programmer.DateLeave = programmer.DateLeave;

                _context.SaveChanges();
            }
        }

        public List<Programmer> GetAllProgrammers() => _context.Programmers.ToList();
        

        public void RemoveProgrammer(uint id)
        {
            var _programmer = _context.Programmers.FirstOrDefault(n => n.Id == id);

            if(_programmer != null)
            {
                _context.Programmers.Remove(_programmer);
                _context.SaveChanges();
            }
        }
    }
}
