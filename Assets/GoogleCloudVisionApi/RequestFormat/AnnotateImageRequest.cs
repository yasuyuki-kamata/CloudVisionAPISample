using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class AnnotateImageRequest
	{
		[SerializeField] List<Feature> features;
		[SerializeField] ImageContext imageContext;
		[SerializeField] Image image;

		public AnnotateImageRequest(Image _image, List<Feature> _features, ImageContext _imageContext)
		{
			image = _image;
			features = _features;
			imageContext = _imageContext;
		}
	}

	[Serializable]
	public class ImageContext
	{
		[SerializeField] LatLongRect latLongRect;
		[SerializeField] string languageHints;
	}

	[Serializable]
	public class LatLongRect
	{
		[SerializeField] LatLng minLatLng;
		[SerializeField] LatLng maxLatLng;
	}
}