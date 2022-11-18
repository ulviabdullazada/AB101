namespace Class.Models
{
    internal class Teacher:Person
    {
        public byte Experience;

        public Teacher() //parameterless
        {
        }
        public Teacher(string Name) : base(Name)
        {
        }
        public Teacher(string Name, string Surname) : base(Name, Surname)
        {
        }
        public Teacher(string Name, string Surname, int Age) : base(Name, Surname, Age)
        {
        }
        public Teacher(string Name, string Surname, int Age, byte Experience) : this(Name, Surname, Age)
        {
            this.Experience = Experience;
        }
    }
}
