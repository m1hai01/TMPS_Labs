using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
     class Motorcycle : DriveExperience
    {
        public override void CompetentAge()
        {
            Console.WriteLine("Implinim 16 ani");
        }
        
        public override void GetDrivingLicense()
        {
            Console.WriteLine("Primim permisul de conducere A1");
        }

    }
}
