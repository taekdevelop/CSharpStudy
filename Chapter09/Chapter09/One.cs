namespace Chapter09
{
    class NameCard
    {
        private int mAge;
        private string mName;

        public int Age
        {
            get
            {
                return mAge;
            }

            set
            {
                mAge = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
    }
}
