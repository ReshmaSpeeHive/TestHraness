using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityFunctions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class InformationAttribute : Attribute
    {
        public string Description { get; set; }
    }
}
