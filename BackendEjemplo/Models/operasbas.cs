using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace BackendEjemplo.Models
{
    public class operasbas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Rest { get; set; }

        public void Suma()
        {
            this.Rest = this.Num1 + this.Num2;
        }
        public void Resta()
        {
            this.Rest = this.Num1 - this.Num2;
        }
    }
}