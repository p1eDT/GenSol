using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome6
{
    public class Doctor : Person
    {
        public DoctorType DoctorType { get; set; }

        public Doctor(string name, DoctorType doctorType) : base(name)
        {
            DoctorType = doctorType;
        }

        public void Show()
        {
            ShowInfo();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ilnessType: {DoctorType}");
        }

        public void Treat(DoctorType doctorType)
        {
            if (DoctorType == doctorType)
            {
                Console.Write($"by a {doctorType} named {Name}");
            }
        }
    }
}
