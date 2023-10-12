using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNET
{
    class TestItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

        public string Description { get; set; }
        public string Type { get; set; }    

        public TestItem(string name)
        {
            Name = name;
        }

        public bool InternalFunction(int a)
        {
            return a == Id;
        }       
        
        public bool Check(int a)
        {
            return a == Id;
        }

        public void TestFunction(int a, int b)
        {
            InternalFunction(a);
        }

        public int FailFUNCTIONNAME()
        {
            TestItem? test = new TestItem("Ok");

            if(Check(1) == true)
            {
                return 2;
            }
            else
            {
                return test.Id;
            }
            
        }

        public string TotalFunction()
        {
            TestFunction(1,2);
            FailFUNCTIONNAME();

            return string.Empty;
        }


        public TestItem? Clone()
        {
            if(Id == 100)
            {
                return this;
            }
            else{
                return null;
            }
        }
    }
}
