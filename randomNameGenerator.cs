using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator
{
    public class NamesGenerator
    {
        
        private static string[] teamMember = { "Sam", "Nick", "Chris", "Josh", "Sarah","Jarad", "Mary", "John", "Rachel","Sophie", "Karl", "Jo" };

        public static string GenerateName()
        {
            var rand = new Random();
            string randomTeamMember = teamMember[rand.Next(teamMember.Length)];

            return $"{randomTeamMember}";
        }
    }
}
