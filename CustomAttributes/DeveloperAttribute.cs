using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{

        [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
  sealed   class DeveloperAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        //readonly string positionalString;

        // This is a positional argument
        public DeveloperAttribute(string devname)
        {
            //this.positionalString = positionalString;

            // TODO: Implement code here
            this.DeveloperName = devname;
            //throw new NotImplementedException();
        }

        //public string PositionalString
        //{
        //    get { return positionalString; }
        //}

        // This is a named argument
        public int NamedInt { get; set; }
        public string DeveloperName { get; set; }


    }
}
