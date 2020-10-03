using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {

        //You can have multiple class with the same name in one project,
        //but they HAVE to belong to different Namespaces!
        //--------------------------------------------------------------
        //Elementary.Volume elementaryVolume;
        //HighSchool.Volume highScoolVolume;


        //There are 4 ACCESS MODIFIERS IN C#
        //----------------------------------
        //1.  public (accessed from anywhere)

        //2.  private (only access from within this class)

        //3.  protected
        
        //4.  internal - THE DEFAULT!


        //Fields -- It is bad practice to create fields like this
        //because they are exposed to anyone.
        //----------------------------------------------------
        //string SchoolName;
        //string SchoolAddress;
        //string SchoolCity;
        //string SchoolState;
        //string SchoolZip;
        //string PhoneNumber;

        //It is good practice to encaptulate your fields as properties
        //------------------------------------------------------------

        //a) auto properties

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        //An encapsulated property
        //------------------------
        private string _twitterAddress; 
        public string TwitterAddress
        {
            get { return _twitterAddress; }

            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        // CONSTRUCTOR (short cut:  type ctor tab tab)
        //--------------------------------------------

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string schoolName, string schoolPhoneNumber)
        {
            Name = schoolName;
            PhoneNumber = schoolPhoneNumber;
        }

        //METHODS
        //--------------------------------------------------------------------------------------------------
        //OVERLOADING (POLYMORPHISM) - means you have methods with the same name, but a different signature.
        //Signature = name + type and number of arguments passed in
        //--------------------------------------------------------------------------------------------------

        public static float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public static int AverageThreeScores(int a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return (int)Math.Round(result);
        }

        //Function bodied expression
        //Use for simple things, not for anything complex
        //-----------------------------------------------

        //public float AverageTwoScores(float a, float b)
        //{
        //    var result = (a + b) / 2;
        //    return result;
        //}

        public float AverageTwoScores(float a, float b) => (a + b) / 2;

        //Overriding ToString
        //Every object in C# inherits from the Base Class named Object
        //-------------------------------------------------------------

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);
            return sb.ToString();
        }
    }
}

