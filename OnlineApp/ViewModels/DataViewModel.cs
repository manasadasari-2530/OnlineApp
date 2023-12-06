using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    public class DataViewModel
    {
        public DataModel DataModel { get; set; }
        public DataViewModel()
        {
            this.DataModel = new DataModel();
        }
    }
}
