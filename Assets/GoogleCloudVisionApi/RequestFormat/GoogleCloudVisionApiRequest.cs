using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class GoogleCloudVisionApiRequest
	{
		[SerializeField] List<AnnotateImageRequest> requests;

		public GoogleCloudVisionApiRequest ()
		{
			requests = new List<AnnotateImageRequest> ();
		}

		public void Add (AnnotateImageRequest request)
		{
			requests.Add (request);
		}
	}
}