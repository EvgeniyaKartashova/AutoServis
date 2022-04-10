using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace DemoAutoSevice.Models
{
    partial class Personal
    {
        public byte[] Photo
        {
            get
            {
                if (File.Exists($"photo/{FirstName} {LastName} {MiddleName}.jpg"))
                {
                    return File.ReadAllBytes($"photo/{FirstName} {LastName} {MiddleName}.jpg");
                }
                if (File.Exists($"photo/{FirstName} {LastName} {MiddleName}.png"))
                {
                    return File.ReadAllBytes($"photo/{FirstName} {LastName} {MiddleName}.png");
                }
                return null;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName} {MiddleName}";
            }
        }
    }
}
