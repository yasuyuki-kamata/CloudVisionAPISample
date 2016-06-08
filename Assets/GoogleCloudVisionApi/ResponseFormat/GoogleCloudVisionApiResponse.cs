using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class GoogleCloudVisionApiResponse
	{
		public List<AnnotateImageResponse> responses;
	}
}