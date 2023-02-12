using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFinal.MusicPeople
{
    class Judge : Person
    {
        private string[] generalResponses = { "Very nice performance.", "Good job." };
        public string[] GeneralResponses { get { return generalResponses; } }

        private List<string> uniqueResponses = new List<string>();
        public List<string> UniqueResponses { get { return uniqueResponses; } }

        public Judge(string name, params string[] uniqueResponses) : base(name) 
        {
            foreach (string response in uniqueResponses)
                this.AddUniqueResponse(response);
        }

        public void AddUniqueResponse(string response)
        {
            this.uniqueResponses.Add(response);
        }

        public string GetUniqueResponse()
        {
            Random rnd= new Random();
            int responseId = rnd.Next(this.UniqueResponses.Count);
            return this.UniqueResponses[responseId];
        }

        public string GetGeneralResponse()
        {
            Random rnd = new Random();
            int responseId = rnd.Next(this.GeneralResponses.Length);
            return this.GeneralResponses[responseId];
        }
    }
}
