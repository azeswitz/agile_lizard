using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileLizard.Fbopen.Client.Dto
{
    public class RootObject
    {
        public int numFound { get; set; }
        public int start { get; set; }
        public double maxScore { get; set; }
        public List<Doc> docs { get; set; }
        public Facets facets { get; set; }
    }
}
