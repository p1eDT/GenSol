namespace GitHome6 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Glaznik", DoctorType.Ophthalmologist);
            Doctor doctor2 = new Doctor("Zubolog", DoctorType.Dentist);
            Doctor doctor3 = new Doctor("Allnic", DoctorType.Therapist);
            Doctor[] doctors = { doctor1, doctor2, doctor3 };

            Patient patient1 = new Patient("Oleg", IlnessType.Other);
            Patient patient2 = new Patient("Tolyan", IlnessType.Teeth);
            Patient patient3 = new Patient("Evgen", IlnessType.Eyes);
            Patient[] patients = { patient1, patient2, patient3 };

            Clinic clinic = new Clinic("NewClinic", doctors, patients);

            clinic.Treating(patients);
        }
    }
}