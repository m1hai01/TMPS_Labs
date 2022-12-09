using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.TemplateMethod
{
    abstract class DriveExperience
    {
        public void Start()
        {
            CompetentAge();
            StudyAndPractice();
            PassExams();
            GetDrivingLicense();
        }

        public abstract void CompetentAge();

        public  virtual void StudyAndPractice()
        {
            Console.WriteLine("Invatam la scoala auto si facem lectiile pratice");
        }
        public virtual void PassExams()
        {
            Console.WriteLine("Sustinerea examenilor la AMR");
        }
        public abstract void GetDrivingLicense();
    }
}
