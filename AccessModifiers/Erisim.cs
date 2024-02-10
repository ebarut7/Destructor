using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Erisim
    {
        public Erisim()
        {
            this.Private = "";
        }
        public string Public{ get; set; }
        private string Private { get; set; }
        protected string Prodtected { get; set; }
        internal string Internal { get; set; }  
        protected internal string ProtectedInternal { get; set; }
    }
}
