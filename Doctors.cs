using System.Collections;

namespace FinalExam
{
    class Doctors : CollectionBase
    {
        public void add(Doctor doctor)
        {
            List.Add(doctor);
        }
        public Doctor this[int index]
        {
            get
            {
                return (Doctor)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}