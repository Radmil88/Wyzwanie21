namespace Wyzwanie21
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name)
        {
            this.Name = name;
           
        }

        public string Name { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int score)
        {
           
                this.score.Add(score);

    
        }
    }
}
