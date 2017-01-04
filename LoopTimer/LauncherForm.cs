using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoopTimer.Properties;
using TTimer = System.Threading.Timer;
using FTimer = System.Windows.Forms.Timer;

namespace LoopTimer
{
	public partial class LauncherForm : Form
	{
		private TTimer tTimer;
		private FTimer fTimer;
		private TimeSpan time, fullTime;

		public LauncherForm()
		{
			InitializeComponent();
			time = new TimeSpan(0, (int)numHours.Value, 0, 0);
			fTimer = new FTimer();
			fTimer.Interval = 1000;
			fTimer.Tick += (sender, args) =>
			{
				time = new TimeSpan(0, time.Hours, time.Minutes, time.Seconds - 1);
				timerDisplay.Text = time.ToString(@"hh\:mm\:ss");
			};

			PrivateFontCollection f = new PrivateFontCollection();
			f.AddFontFile("font_data.bin");

			timerDisplay.Font = new Font(f.Families[0], 48);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			var tickPeriod = new TimeSpan(
				0, 
				(int)numHours.Value, 
				(int)numMinutes.Value, 
				(int)numSeconds.Value
				);

			tTimer = new TTimer(timer_Tick, null, tickPeriod, tickPeriod);
			fullTime = tickPeriod;
			SetTime(fullTime);
			fTimer.Start();

			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
		}
		
		public void timer_Tick(object state)
		{
			using (Stream stream = Resources.MarioCoin)
			{
				SoundPlayer snd = new SoundPlayer(stream);
				snd.Play();
				time = new TimeSpan(0, fullTime.Hours, fullTime.Minutes, fullTime.Seconds);
			}
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			tTimer.Dispose();
			tTimer = null;
			fTimer.Stop();
			SetTime(fullTime);

			buttonStop.Enabled = false;
			buttonStart.Enabled = true;
		}
		
		private void SetTime(TimeSpan tm)
		{
			time = new TimeSpan(0, tm.Hours, tm.Minutes, tm.Seconds);
			timerDisplay.Text = time.ToString(@"hh\:mm\:ss");
		}

		private void button_EnabledChanged(object sender, EventArgs e)
		{
			var control = sender as Control;
			if (control != null)
			{
				control.BackColor = control.BackColor == Color.Black 
					? Color.Gray : Color.Black;
			}
		}
	}
}
