namespace Final
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName
        {
            get { return Name; }
        }

        public double GetWeight
        {
            get { return Weight; }
        }
    }    
}
