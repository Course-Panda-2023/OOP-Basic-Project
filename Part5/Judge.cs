using System.Reflection;

namespace MySingingContest
{
    class Judge
    {
        private string name;

        public Judge(string name) 
        {
            this.name = name;
        }

        public string GetName() { return this.name; }

        public Participant ChooseWinner(Participant[] participants)
        {
            Song[] songList = new Song[0];
            for (int i = 0; i < participants.Length; i++)
            {
                songList.Append(participants[i].SingASong());
            }
            Random rnd = new Random();
            int num = rnd.Next(songList.Length);
            return participants[num];
        }
        public void AnnounceWinner(Participant winner) 
        {
            Console.WriteLine($"{this.name}: The winner is {winner.GetName()}!");

        }
        public Participant Duel(Participant participant1, Participant participant2)
        {
            Participant[] participants = { participant1, participant2 };
            Participant winner = this.ChooseWinner(participants);
            this.AnnounceWinner(winner);
            return winner;
        }

        // Part2:
        public void Tournament(Participant[] participants)
        {
            participants = RandomizeArray(participants);
            double rounds = Math.Ceiling(Math.Log2(participants.Length));
            for (int i = 0; i < rounds; i++)
            {
                int participantsLeft = (int)Math.Pow(2, rounds - i);
                Console.WriteLine($"\nthis round will be held as if there are {participantsLeft} participants left");
                for (int j = 0; j < participantsLeft / 2; j++)
                {
                    DuelInTournament(participants, j, j+ participantsLeft / 2);
                }
            }
            string announcment = $"{this.name}: The Final winner is {participants[0].GetName()}!";
            Console.WriteLine(announcment);
        }

        public Participant[] RandomizeArray(Participant[] array)
        {
            Random rnd = new Random();
            Participant[] RandomArray = array.OrderBy(x => rnd.Next()).ToArray();
            return RandomArray;

        }

        public void DuelInTournament(Participant[] participants, int participant1Index, int participant2Index)
        {
            if (participant2Index < participants.Length)
            {
                participants[participant1Index] = Duel(participants[participant1Index], participants[participant2Index]);
                participants[participant2Index] = null;
                return;
            }
            Console.WriteLine($"{this.name}: {participants[participant1Index].GetName()} with {participants[participant1Index].GetSongs()[0].GetName()} wins automatically");
        }
    }
}