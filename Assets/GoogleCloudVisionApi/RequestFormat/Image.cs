using UnityEngine;
using System;
using System.Collections;
using System.Text;

namespace GCVAPISample
{
	[Serializable]
	public class Image
	{
		[SerializeField] string content;

		public Image (Texture2D texture)
		{
			byte[] bytes = texture.EncodeToPNG ();
			content = Convert.ToBase64String (bytes);
		}
	}
}