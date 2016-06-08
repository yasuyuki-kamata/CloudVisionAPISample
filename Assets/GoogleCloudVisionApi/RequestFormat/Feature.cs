using UnityEngine;
using System;
using System.Collections;

namespace GCVAPISample
{
	[Serializable]
	public class Feature
	{
		[SerializeField] private string type;
		[SerializeField] private int maxResults;

		public Feature (FeatureType _type, int _maxResults)
		{
			type = _type.GetTypeName();
			maxResults = _maxResults.Equals(0) ? 3: _maxResults;
		}
	}

	public enum FeatureType
	{
		TYPE_UNSPECIFIED,
		FACE_DETECTION,
		LANDMARK_DETECTION,
		LOGO_DETECTION,
		LABEL_DETECTION,
		TEXT_DETECTION,
		SAFE_SEARCH_DETECTION,
		IMAGE_PROPERTIES
	}

	public static class FeatureTypeExtention
	{
		public static string GetTypeName (this FeatureType featureType)
		{
			string[] names = {
				"TYPE_UNSPECIFIED",
				"FACE_DETECTION",
				"LANDMARK_DETECTION",
				"LOGO_DETECTION",
				"LABEL_DETECTION",
				"TEXT_DETECTION",
				"SAFE_SEARCH_DETECTION",
				"IMAGE_PROPERTIES"
			};
			return names[(int) featureType];
		}
	}
}