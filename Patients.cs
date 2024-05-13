using System.Collections;

namespace FinalExam
{
    class Patients : CollectionBase
    {
        public void add(Patient patient)
        {
            List.Add(patient);
        }
        public Patient this[int index]
        {
            get
            {
                return (Patient)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
