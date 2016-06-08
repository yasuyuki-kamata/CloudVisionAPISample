using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GCVAPISample
{
	[Serializable]
	public class FaceAnnotation
	{
		public BoundingPoly boundingPoly;
		public BoundingPoly fdBoundingPoly;
		public List<Landmark> landmarks;
		public int rollAngle;
		public int panAngle;
		public int tiltAngle;
		public int detectionConfidence;
		public int landmarkingConfidence;
//		public Likelihood joyLikelihood;
//		public Likelihood sorrowLikelihood;
//		public Likelihood angerLikelihood;
//		public Likelihood surpriseLikelihood;
//		public Likelihood underExposedLikelihood;
//		public Likelihood blurredLikelihood;
//		public Likelihood headwearLikelihood;
		public string joyLikelihood;
		public string sorrowLikelihood;
		public string angerLikelihood;
		public string surpriseLikelihood;
		public string underExposedLikelihood;
		public string blurredLikelihood;
		public string headwearLikelihood;
	}
}