namespace Iterator
{
    class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsVegin { get; private set; }
        public float Price { get; private set; }

        public void Init(string name, string description, bool isVegin, float price)
        {
            Name = name;
            Description = description;
            IsVegin = isVegin;
            Price = price;
        }

        public MenuItem()
        {

        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Descr = {1}, IsVegin = {2},  Price = {3}", Name, Description, Name, Price);
        }
    }
}
