namespace DistributedObject
{
    internal class Property
    {
        private string name;
        private string type;
        private string value;

        public Property(string name, string type, string value)
        {
            this.name = name;
            this.type = type;
            this.value = value;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}