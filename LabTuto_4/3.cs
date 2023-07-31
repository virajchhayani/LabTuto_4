using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_4
{
    // Task 1: Create a class
    // Parent class
    class ParentClass
    {
        // Task 2: Add few data members as private, protected, and public
        private int privateData;       // Private data member can only be accessed within the class.
        protected int protectedData;   // Protected data member can be accessed within the class and its derived classes.
        public int publicData;         // Public data member can be accessed from anywhere.
        // Task 3: Add few methods as public to work on defined data members
        public ParentClass(int privateData, int protectedData, int publicData)
        {
            this.privateData = privateData;
            this.protectedData = protectedData;
            this.publicData = publicData;
        }
        // Method to display data members
        public void DisplayData()
        {
            Console.WriteLine("Private Data: " + privateData);
            Console.WriteLine("Protected Data: " + protectedData);
            Console.WriteLine("Public Data: " + publicData);
        }
    }
    // Task 4: Create another applicable class which inherits members from above class
    // Child class inheriting from ParentClass
    class ChildClass : ParentClass
    {
        // Task 5: Add few data members as private, protected, and public into second class
        private string privateInfo;      // Private data member in the child class.
        protected string protectedInfo;  // Protected data member in the child class.
        public string publicInfo;        // Public data member in the child class.
        // Task 6: Add few methods as public to work on defined data members into second class
        public ChildClass(int privateData, int protectedData, int publicData, string privateInfo, string protectedInfo, string publicInfo)
            : base(privateData, protectedData, publicData)
        {
            this.privateInfo = privateInfo;
            this.protectedInfo = protectedInfo;
            this.publicInfo = publicInfo;
        }
        // Method to display child class data members
        public void DisplayInfo()
        {
            Console.WriteLine("Private Info: " + privateInfo);
            Console.WriteLine("Protected Info: " + protectedInfo);
            Console.WriteLine("Public Info: " + publicInfo);
        }
    }
    // Task 7: Create a Demo class with main method
    class Demo
    {
        static void Main()
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            // Task 8: Create at least two objects of a second class defined in Task 4 into main method and call all methods using that object.
            ChildClass obj1 = new ChildClass(1, 2, 3, "PrivateInfo1", "ProtectedInfo1", "PublicInfo1");
            ChildClass obj2 = new ChildClass(4, 5, 6, "PrivateInfo2", "ProtectedInfo2", "PublicInfo2");
            Console.WriteLine("Object 1:");
            obj1.DisplayData();   // Display data from ParentClass using obj1
            obj1.DisplayInfo();   // Display data from ChildClass using obj1
            Console.WriteLine("\nObject 2:");
            obj2.DisplayData();   // Display data from ParentClass using obj2
            obj2.DisplayInfo();   // Display data from ChildClass using obj2
        }
    }
}
