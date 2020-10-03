using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{

    //You can only inherit from 1 Base Class
    //You can inherit from more than 1 interface
    //You can inherit from 1 Base Class + as many interfaces as necessary
    //Separate the base class and each interface by a comma
    public class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
