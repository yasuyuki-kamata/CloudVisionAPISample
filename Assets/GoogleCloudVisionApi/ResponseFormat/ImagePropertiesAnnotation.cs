using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class ImagePropertiesAnnotation
	{
		public DominantColorsAnnotation dominantColors;
	}

	[Serializable]
	public class DominantColorsAnnotation
	{
		public List<ColorInfo> colors;
	}

	[Serializable]
	public class ColorInfo
	{
		public GCVAPISample.Color color;
		public float score;
		public float pixelFraction;
	}

	[Serializable]
	public class Color
	{
		public float red;
		public float green;
		public float blue;
		public float alpha;
	}
}