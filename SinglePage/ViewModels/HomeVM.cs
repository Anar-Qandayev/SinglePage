using SinglePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.ViewModels
{
    public class HomeVM
    {
        public List<About> Abouts { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Award> Awards { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
