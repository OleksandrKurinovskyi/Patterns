namespace Iterator
{
    class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsVegin { get; private set; }
        public float Price { get; private set; }

        public MenuItem(string name, string description, bool isVegin, float price)
        {
            Name = name;
            Description = description;
            IsVegin = isVegin;
            Price = price;
        }
    }
}
