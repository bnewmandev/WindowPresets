using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowClasses
{
    class Profile
    {
        public string ProfileName;
        public string Description;
        public List<Window> Windows;

        public Profile(List<Window> windows, string profileName, string description)
        {
            ProfileName = profileName;
            Description = description;
            Windows = windows;
        }
        
    }
}
