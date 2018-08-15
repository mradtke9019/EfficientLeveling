using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfficientLeveling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Player player = JsonConvert.DeserializeObject<Player>(File.ReadAllText(@"C:\Users\mradt\source\repos\EfficientLeveling\EfficientLeveling\samplePlayer.json"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
