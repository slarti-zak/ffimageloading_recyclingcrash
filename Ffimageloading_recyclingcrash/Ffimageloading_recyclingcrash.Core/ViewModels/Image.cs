using System;

namespace Ffimageloading_recyclingcrash.Core.ViewModels
{
	public class Image
	{
		public string Url { get; }
		public Tuple<int, int> DownSampleSize => Tuple.Create(200, 200);

		public Image(string url)
		{
			Url = url;
		}
	}
}