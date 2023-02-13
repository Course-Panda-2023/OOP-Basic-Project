namespace Music
{
    abstract class Person
    {
        protected string _fullName;
        public Person(string fullName)
        {
            _fullName = fullName;
        }
        public string GetFullName()
        {
            return _fullName;
        }

        public override string ToString()
        {
            return this.GetFullName();
        }
    }
}