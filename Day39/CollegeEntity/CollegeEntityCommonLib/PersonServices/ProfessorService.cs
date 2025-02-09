using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntityCommonLib.Models;

namespace CollegeEntityCommonLib.PersonServices
{
    public class ProfessorService
    {
        public List<Professor> professors = new List<Professor>();

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }
    }
}
