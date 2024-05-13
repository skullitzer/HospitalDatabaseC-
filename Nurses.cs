using System.Collections;

namespace FinalExam
{
    class Nurses : CollectionBase
    {
        public void add(Nurse nurse)
        {
            List.Add(nurse);
        }
        public Nurse this[int index]
        {
            get
            {
                return (Nurse)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}