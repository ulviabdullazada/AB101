namespace AccessModifiers.Models.Abc.BCD.EFG
{
    public class Person
    {
        //public - her yerde el chatandir.
        public string Surname { get; set; }
        //internal - yalnizca oz assembly-i daxilinde her yerde el chatandir
        internal string Name { get; set; }
        //protected - oz classi daxilinde ve miras alinan class daxilinde el chatandir.
        protected float Salary { get; set; }
        //private - sadece class daxilinde el chatandir ve butun memberlar-in default access modifieridir. Instance alinanda elchatan olmur
        private string[] Fears { get; set; }
        //private protected - sadece oz assembly-inde miras alinan zaman ve oz classi daxilinde el chatandir
        private protected float Salary1 { get; set; }
        //protected internal - Oz assembly-inde internal kimidir. Bashqa assembly-da yalnizca miras alinan zaman el chatandir
        protected internal float Salary2 { get; set; }

    }
}
