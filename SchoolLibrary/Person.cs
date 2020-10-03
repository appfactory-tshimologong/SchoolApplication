using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //An abstract method has to be overriden by a method in any inheriting classes because it 
        //does not have an implementation
        public abstract float GradePointAverage();

        //A virtual method can be overriden by any inheriting classes, but it is not mandatory. 
        // This is because a default implementation is provided in the base class.
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D}, at {0:t)", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();

        }
    }
}
