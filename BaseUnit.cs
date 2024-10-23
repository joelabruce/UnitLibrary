namespace UnitLibrary
{
    public static class BaseUnit
    {
        public static readonly Unit s = new() { Symbol = "s", Name = "second", Quantity = "time" };
        public static readonly Unit m = new() { Symbol = "m", Name = "meter", Quantity = "length" };
        public static readonly Unit kg = new() { Symbol = "kg", Name = "kilogram", Quantity = "mass" };
        public static readonly Unit A = new() { Symbol = "A", Name = "ampere", Quantity = "electric current" };
        public static readonly Unit K = new() { Symbol = "K", Name = "kelvin", Quantity = "thermodynamic temperature" };
        public static readonly Unit mol = new() { Symbol = "mol", Name = "mole", Quantity = "amount of substance" };
        public static readonly Unit cd = new() { Symbol = "cd", Name = "candela", Quantity = "luminous intensity" };
    }
}
