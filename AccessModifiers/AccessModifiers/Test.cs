namespace AccessModifiers
{
    internal class Test
    {
        //public readonly int Age = 14;
        //public int Age { get; } = 14;
        public const int Age = 56;
        public Test()
        {
        }
        public Test(int age)
        {
            //Age = age;
        }
        void B()
        {
            //Age = 23487;
        }
    }
}
