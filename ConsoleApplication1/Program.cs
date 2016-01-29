using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace    ConsoleApplication1
{
            class Program
    {        //[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Reviewed.")]
                     public event Action<int> eventWithoutUpperCase;

        //[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1303:ConstFieldNamesMustBeginWithUpperCaseLetter", Justification = "Reviewed.")]
        public const string constWithLowerCase = "CONST";
        
        //[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:AccessibleFieldsMustBeginWithUpperCaseLetter", Justification = "Reviewed.")]
        public string accessibleFieldsWithLowerCase = "AccessibleField";

        //[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1304:NonPrivateReadonlyFieldsMustBeginWithUpperCaseLetter", Justification = "Reviewed.")]
        public string FieldWithUpperCase;
                   static void Main(string[] args)
        {
            Uri uri = new Uri("file:///C:/Program Files/ThisIsMyAddIn/ThisIsMyAddin.vsto|vstolocal");
            Console.WriteLine(uri.ToString());
            Console.Read();
        }
    }
}
