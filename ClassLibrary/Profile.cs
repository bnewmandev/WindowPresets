using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Profile
    {
        public string Name;
        public string Description;
        public List<SavedWindow> SavedWindows;

        public Profile(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void AddWindow(SavedWindow newWindow)
        {
            SavedWindows.Add(newWindow);
        }

    }
}
