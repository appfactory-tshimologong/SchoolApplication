using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public GradeLevels GradeLevel { get; set; }

        public enum GradeLevels { Freshman, Sophomore, Junior, Senior };

        public override float GradePointAverage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            //Call the method in the Person Class
            var original = base.SendMessage(message);

            //Append extra text
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }

    }
}
