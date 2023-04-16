using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome6
{
    public class AssociationDoctorToIlness
    {
        public DoctorType DoctorType { get; set; }

        public IlnessType IlnessType { get; set; }

        public DoctorType AssociatDoctorToIlness(IlnessType ilnessType)
        {
            switch (ilnessType)
            {
                case IlnessType.Teeth:
                    DoctorType = DoctorType.Dentist; break;
                case IlnessType.Eyes:
                    DoctorType = DoctorType.Ophthalmologist; break;
                case IlnessType.Other:
                    DoctorType = DoctorType.Therapist; break;
            }
            return DoctorType;
        }
    }
}
