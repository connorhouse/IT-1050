namespace Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;
            for (int i = 0; i < Occupants.Length; i++)
            {
                totalWeight += Occupants[i].GetWeight;
            }
            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }
}
