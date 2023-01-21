using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace Test1
{
    class Program
    {

        private void Write()
        {
            var class1 = new BaseClass1();
            class1.SaHello();

            var class2 = new Class2();
            class2.SaHello();

            var cl1 = StaticClass1.SayHi();

            var drv=class1.GetDriverInsance();


        }


    }
}

