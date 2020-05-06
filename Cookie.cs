using System;

namespace Lesson_05
{
    class Cookie
    {
        private Boolean gloten;
        public Boolean Gloten
        {
            get { return gloten; }
            set { gloten = value; }
        }

        private int numOfEggs;
        public int NumOfEggs
        {
            get { return numOfEggs; }
            set
            {
                if (value > 0)
                    numOfEggs = value;
            }
        }

        private float numOfSuger;
        public float NumOfSuger
        {
            get { return numOfSuger; }
            set { numOfSuger = value; }
        }

        private float amountflour;
        public float Amountflour
        {
            get { return amountflour; }
            set { amountflour = value; }
        }

    }
}
