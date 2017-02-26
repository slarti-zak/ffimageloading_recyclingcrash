using FFImageLoading.Transformations;
using FFImageLoading.Work;
using System;
using System.Collections.Generic;

namespace Ffimageloading_recyclingcrash.Core.ViewModels
{
	public class Image
	{
		public string Url { get; }
		public Tuple<int, int> DownSampleSize => Tuple.Create(200, 200);
		public List<ITransformation> Transformations => new List<ITransformation> { new CircleTransformation() };

		public Image(string url)
		{
			Url = url;
		}
	}
}