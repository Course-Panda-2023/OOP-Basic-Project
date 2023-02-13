public class Judge : Person
    {
        public Judge(string Name) : base(Name)
        {

        }

        public Singer ChooseWinner(SingingContest contest)
        {
            Random rand = new Random();
            List<Person> singerList = contest.getSingers();
            int winnerIndex = rand.Next(singerList.Count);
            Console.WriteLine($"judge {this.Name}: hmmm... the winner is {singerList[winnerIndex].Name}");
            return (Singer)singerList[winnerIndex];    
        }
    }

