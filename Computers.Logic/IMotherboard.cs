namespace Computers.Logic
{
    public interface IMotherboard
    {
        /// <summary>
        /// Loads value from Ram
        /// </summary>
        /// <returns>The loaded value</returns>
        int LoadRamValue();

        /// <summary>
        /// Saves the given Ram value
        /// </summary>
        /// <param name="value"> The Value to save </param>
        void SaveRamValue(int value);

        /// <summary>
        /// Draws text in video card
        /// </summary>
        /// <param name="data"> the text to draw </param>
        void DrawOnVideoCard(string data);
    }
}
