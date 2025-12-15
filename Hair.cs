using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb4
{
    public struct Hair
    {
            public string HairColor { get; set; }
            public string HairLength { get; set; }

        // Metod som returnerar Hair-objekt i string
        public override string ToString()
        {
            return $"{HairLength}, och {HairColor}";
        }
      
    }
}
