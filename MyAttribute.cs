using System;
using System.Collections.Generic;
using System.Text;

namespace Annotations
{
    public class MyAttribute : Attribute
    {
        public string title;
        public string description;
        public MyAttribute(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
