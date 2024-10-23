namespace UnitLibrary
{
    public class UnitPrefix
    {
        public static readonly UnitPrefix Q = new UnitPrefix("quetta", "Q", 30);
        public static readonly UnitPrefix R = new UnitPrefix("ronna", "R", 27);
        public static readonly UnitPrefix Y = new UnitPrefix("yotta", "Y", 24);
        public static readonly UnitPrefix Z = new UnitPrefix("zetta", "Z", 21);
        public static readonly UnitPrefix E = new UnitPrefix("exa", "E", 18);
        public static readonly UnitPrefix P = new UnitPrefix("peta", "P", 15);
        public static readonly UnitPrefix T = new UnitPrefix("tera", "T", 12);
        public static readonly UnitPrefix G = new UnitPrefix("giga", "G", 9);
        public static readonly UnitPrefix M = new UnitPrefix("mega", "M", 6);
        public static readonly UnitPrefix k = new UnitPrefix("kilo", "k", 3);
        public static readonly UnitPrefix h = new UnitPrefix("hecto", "h", 2);
        public static readonly UnitPrefix da = new UnitPrefix("deca", "da", 1);
        public static readonly UnitPrefix d = new UnitPrefix("deci", "d", -1);
        public static readonly UnitPrefix c = new UnitPrefix("centi", "c", -2);
        public static readonly UnitPrefix m = new UnitPrefix("milli", "m", -3);
        public static readonly UnitPrefix u = new UnitPrefix("micro", "µ", -6);
        public static readonly UnitPrefix n = new UnitPrefix("nano", "n", -9);
        public static readonly UnitPrefix p = new UnitPrefix("pico", "p", -12);
        public static readonly UnitPrefix f = new UnitPrefix("femto", "f", -15);
        public static readonly UnitPrefix a = new UnitPrefix("atto", "a", -18);
        public static readonly UnitPrefix z = new UnitPrefix("zepto", "z", -21);
        public static readonly UnitPrefix y = new UnitPrefix("yocto", "y", -24);
        public static readonly UnitPrefix r = new UnitPrefix("ronto", "r", -27);
        public static readonly UnitPrefix q = new UnitPrefix("quecto", "q", -30);

        /// <summary>
        /// Name of prefix.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Symbol of prefix.
        /// </summary>
        public string Symbol { get; }
        /// <summary>
        /// The value to be used in the exponent of base 10.
        /// </summary>
        public int Exponent { get; }

        private UnitPrefix(string prefixName, string prefixSymbol, int prefixExponent)
        {
            Name = prefixName;
            Symbol = prefixSymbol;
            Exponent = prefixExponent;
        }
    }
}
