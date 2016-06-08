using UnityEngine;
using System;
using System.Collections;

namespace GCVAPISample
{
	[Serializable]
	public class SafeSearchAnnotation
	{
//		public Likelihood adult;
//		public Likelihood spoof;
//		public Likelihood medical;
//		public Likelihood violence;
		public string adult;
		public string spoof;
		public string medical;
		public string violence;
	}
}