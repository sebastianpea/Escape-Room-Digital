using Escape_Room_Digital;

namespace Escape_Room_Digital
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                AudioManager.CargarPlaylist(new List<string> 
                {
                    "Audio/HipShop.mp3" 
                });
                AudioManager.ReproducirSiguiente();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }
}