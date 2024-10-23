namespace UnitLibrary
{
    public class DerivedUnit : Unit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static DerivedUnit operator +(DerivedUnit a, DerivedUnit b)
        {
            if (!a.Name.Equals(b.Name))
            {
                throw new ArgumentException("Cannot add units because they measure different phenomenon.");
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static DerivedUnit operator -(DerivedUnit a, DerivedUnit b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static DerivedUnit operator *(DerivedUnit a, DerivedUnit b)
        {
            throw new NotImplementedException();
        }

        public static DerivedUnit operator /(DerivedUnit a, DerivedUnit b)
        {
            throw new NotImplementedException();
        }

        public bool MeasureSameThing(DerivedUnit a, DerivedUnit b)
        {
            throw new NotImplementedException();
        }
    }

    public static class UnitExtensions
    {
        public static DerivedUnit u(this float amount, UnitPrefix prefix, Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}
