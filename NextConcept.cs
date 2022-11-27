using System;
using System.Collections.Generic;
using System.Text;

namespace Annotations
{
    public class AttributeManager
    {
        public static void DisplayAttributeUsage(Type type)
        {
            Console.WriteLine("MyAttribute is used is class: "+type.Name);
            Console.WriteLine("Methods of class: "+type.Name);
            var methodsInfo=type.GetMethods();
            foreach(var method in methodsInfo)
            {
                object[] attributesArray=method.GetCustomAttributes(typeof(MyAttribute),true);
                foreach(var attribute in attributesArray)
                {
                    var myAttribute=attribute as MyAttribute;
                    Console.WriteLine($"MethodName: {method.Name} AttributeTitle: {myAttribute.title} AttributeDesc: {myAttribute.description}");
                }
            }
        }
    }
    public class Employee
    {
        int id;
        string name;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        [MyAttribute("Accessor", "Gives Values of Employee ID")]
        public int GetId()
        {
            return id;
        }
        [MyAttribute("Accessor", "gives employee name")]
        public string GetName()
        {
            return name;
        }
    }
}
