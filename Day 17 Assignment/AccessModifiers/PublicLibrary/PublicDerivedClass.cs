using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace PublicLibrary
{
    public class PublicDerivedClass : BaseClass
    {
        public void PublicDerivedClassMethod()
        {
            //Private and internal variables cannot be accessed in public derived class method in other assembly
            
            a = 11;
            //b = 22;
            c = 33;
            //d = 44;
            e = 55;
        }
    }

    public class PublicOtherClass
    {
        public void PublicOtherClassMethod()
        {
            BaseClass bc = new BaseClass();

            // Except public variable, we cannot access other variables in other class method in other assembly

            bc.a = 11;
            //bc.b = 22;
            //bc.c = 33;
            //bc.d = 44;
            //bc.e = 55;
        }
    }
}
