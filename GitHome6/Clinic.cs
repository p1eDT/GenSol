using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome6
{
    public class Clinic
    {
        public string Title { get; set; }

        public Doctor[] Doctors { get; set; }

        public Patient[] Patients { get; set; }

        public IlnessType IlnessType { get; set; }

        public Clinic(string title, Doctor[] doctors, IlnessType ilnessType, Patient[] patients)
        {
            Title = title;
            Doctors = doctors;
            IlnessType = ilnessType;
            Patients = patients;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ilnessType: {Title}");
            foreach (var doctor in Doctors)
            {
                doctor.ShowInfo();
            }
        }

        private DoctorType getDoctorTypeByIlness(IlnessType ilnessType)
        {
            AssociationDoctorToIlness association = new AssociationDoctorToIlness();

            DoctorType doctorType = association.AssociatDoctorToIlness(ilnessType);

            return doctorType;
        }

        public void Treating(Patient[] patients)
        {
            DoctorType doctorType;

            foreach (Patient patient in patients)
            {
                Console.Write($"\n\rThe patient {patient.Name} will be treated {patient.IlnessType} ");
                doctorType = getDoctorTypeByIlness(patient.IlnessType);

                foreach (Doctor doctor in Doctors)
                {
                    doctor.Treat(doctorType);
                }
            }
        }
    }
}
