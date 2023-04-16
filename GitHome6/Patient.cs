using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome6
{
    public class Patient : Person
    {

        public IlnessType IlnessType { get; set; }


        public Patient(string name, IlnessType ilnessType) : base(name)
        {
            IlnessType = ilnessType;
        }

        public void Show()
        {
            ShowInfo();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ilnessType: {IlnessType}");
        }
    }
}
