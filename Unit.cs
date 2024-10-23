namespace UnitLibrary
{
    public class Unit
    {
        /// <summary>
        /// Name of unit.
        /// </summary>
        public string Name { get; init; }
        /// <summary>
        /// Symbol of unit.
        /// </summary>
        public required string Symbol { get; init; }
        /// <summary>
        /// The type of quantity to be measured by unit.
        /// </summary>
        public string Quantity { get; init; }

    }
}
