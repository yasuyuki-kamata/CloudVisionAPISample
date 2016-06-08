using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class EntityAnnotation
	{
		public string mid;
		public string locale;
		public string description;
		public float score;
		public float confidence;
		public float topicality;
		public BoundingPoly boundingPoly;
		public List<LocationInfo> locations;
	}
}