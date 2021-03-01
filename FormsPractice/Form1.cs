using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace FormsPractice
{
	public partial class Form1 : Form
	{
		int imageIndex = 0;
		List<string> images = new List<string>();
		string rssUrl = "https://www.reddit.com/r/ape/";
		int limit = 100;
		int offset = 0;
		XmlDocument rssXml = new XmlDocument();
		bool cycle = false;
		float imagesPerSecond = 3.0f;

		public Form1()
		{
			InitializeComponent();

			timer1.Interval = (int)(1000 / imagesPerSecond);

			InitialiseRSS();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Monkebox.Visible = !Monkebox.Visible;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			UpdateImage();
		}

		void InitialiseRSS()
		{
			rssXml.Load(string.Concat(rssUrl, ".rss?limit=", limit, "&count=", offset));
			XmlNodeList rssNodes = rssXml.GetElementsByTagName("media:thumbnail");
			foreach (XmlNode node in rssNodes)
			{
				string newval = node.Attributes["url"].Value;
				if (newval.Length > 0)
					images.Add(newval);
			}
			Monkebox.ImageLocation = images[0];
		}

		private void Update(object sender, EventArgs e)
		{
			if (cycle)
			{
				UpdateImage();
			}
		}

		private void oncycle(object sender, EventArgs e)
		{
			cycle = !cycle;

			button2.Text = cycle ? "Cycling" : "Cycle truth";
		}

		void UpdateImage()
		{
			++imageIndex;
			if (imageIndex >= limit)
			{
				imageIndex = 0;
				offset += limit;
				InitialiseRSS();
			}


			Monkebox.ImageLocation = images[Math.Min(imageIndex, images.Count - 1)];
			using (WebClient client = new WebClient())
			{
				byte[] data = client.DownloadData(Monkebox.ImageLocation);

				using (MemoryStream mem = new MemoryStream(data))
				{
					using (Image yourImage = Image.FromStream(mem))
					{
						yourImage.Save(string.Concat("monke/monke", imageIndex + offset, ".png"), System.Drawing.Imaging.ImageFormat.Png);
					}
				}
			}
		}
	}
}
