namespace Music
{
    abstract class Person
    {
        protected string _firstName;
        protected string _lastName;
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public override string ToString()
        {
            return this.GetFullName();
        }
    }
}