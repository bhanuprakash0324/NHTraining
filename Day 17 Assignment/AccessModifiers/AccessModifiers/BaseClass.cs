using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Author: Bhanu Prakash Reddy
    //create two assemblies with 3 classes in first assembly, 2 classes in other assembly
    public class BaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void BaseClassMethod()
        {
            //All variables are accessed within the same base class

            a = 11;
            b = 22;
            c = 33;
            d = 44;
            e = 55;
        }
    }

    public class DerivedClass : BaseClass
    {
        public void DerivedClassMethod()
        {
            //In the direct derived class, it does not access private variable in the same assembly

            a = 11;
            //b = 22; 
            c = 33;
            d = 44;
            e = 55;

        }
    }

    public class OtherClass
    {
        public void OtherClassMethod()
        {
            BaseClass bc = new BaseClass();

            //Private and Protected variables cannot be accessed in the other class method in same assembly 
            bc.a = 11;
            //bc.b = 22;
            //bc.c = 33;
            bc.d = 44;
            bc.e = 55;

        }
    }
}
