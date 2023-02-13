namespace MySingingContest
{
    class Drummer : Musician
    {
        private string name;
        public override string GetName() { return this.name; }
        public Drummer(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string template = $" drummer name: {this.name}. ";
            return template;
        } 
    }
    class Guitarist : Musician
    {
        private string name;
        public override string GetName() { return this.name; }
        public Guitarist(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            string template = $" guitarist name: {this.name}. ";
            return template;
        }
    }
}