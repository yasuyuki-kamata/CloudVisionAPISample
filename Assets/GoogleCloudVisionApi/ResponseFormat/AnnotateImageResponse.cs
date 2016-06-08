using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class AnnotateImageResponse
	{
		public List<FaceAnnotation> faceAnnotations;
		public List<EntityAnnotation> landmarkAnnotations;
		public List<EntityAnnotation> logoAnnotations;
		public List<EntityAnnotation> labelAnnotations;
		public List<EntityAnnotation> textAnnotations;
		public SafeSearchAnnotation safeSearchAnnotation;
		public ImagePropertiesAnnotation imagePropertiesAnnotation;
	}

	[Serializable]
	public class BoundingPoly
	{
		public List<Vertex> vertices;
	}

	[Serializable]
	public class Landmark
	{
//		public Type type;
		public string type;
		public Position position;
	}

	[Serializable]
	public class Position
	{
		public int x;
		public int y;
		public int z;
	}

	[Serializable]
	public class Vertex
	{
		public int x;
		public int y;
	}

	[Serializable]
	public class LocationInfo
	{
		public LatLng latLng;
	}

	[Serializable]
	public class LatLng
	{
		public float latitude;
		public float longitude;
	}
}