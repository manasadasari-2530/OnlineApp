using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    public class RegisterViewModel
    {
        public RegisterViewModel()

        {
            this.RegisterModel = new RegisterModel();
        }
        public RegisterModel RegisterModel { get; set; }
    }
}
