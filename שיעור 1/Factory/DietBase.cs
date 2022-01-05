using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IDietBase
    {
        public string DietMenu { get; set; }
        public void GetDiet(); 
    }
}
