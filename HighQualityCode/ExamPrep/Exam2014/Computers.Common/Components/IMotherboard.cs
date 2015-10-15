namespace Computers.Common.Components
{
    /// <summary>
    /// Defines motherboard functionality.
    /// </summary>
    public interface IMotherboard 
    { 
        /// <summary>
        /// Loads value grom RAM.
        /// </summary>
        /// <returns>Loaded value.</returns>
        int LoadRamValue(); 

        /// <summary>
        /// Saves value to RAM.
        /// </summary>
        /// <param name="value">Value to save.</param>
        void SaveRamValue(int value); 

        /// <summary>
        /// Draws data on video card.
        /// </summary>
        /// <param name="data">Data to be drawn.</param>
        void DrawOnVideoCard(string data);
    }
}