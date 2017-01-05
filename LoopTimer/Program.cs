using System;
using System.IO;
using System.Windows.Forms;

namespace LoopTimer
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (!File.Exists("font_data.bin"))
			{
				FileInfo devFile = new FileInfo(@"..\..\font_data.bin");
				if (devFile.Exists) devFile.CopyTo("font_data.bin");
			}
			Application.Run(new LauncherForm());
		}
	}
}
