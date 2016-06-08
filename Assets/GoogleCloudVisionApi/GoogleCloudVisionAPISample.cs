using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GCVAPISample;

public class GoogleCloudVisionAPISample : MonoBehaviour
{
	[SerializeField] string API_KEY =
		"AIzaSyAG6C3bO8lz4Ce41jOhr3ylre95N5avPH4";
	[SerializeField] string API_ENDPOINT =
		"https://vision.googleapis.com/v1/images:annotate?key=";

	public InputField inputField;
	private Texture2D sendTexture;

	[SerializeField, HideInInspector] List<AnnotateImageRequest> requests;

	void Start ()
	{
		if (inputField == null)
			inputField = GameObject.Find ("InputField")
				.GetComponent<InputField> ();
	}

	public void Trigger ()
	{
		RawImage rawImage = transform.parent.GetComponent<RawImage> ();
		sendTexture = (rawImage != null)?
			(Texture2D)transform.parent.GetComponent<RawImage> ().texture:
			Resources.Load<Texture2D> ("Textures/pp1");

		if (sendTexture != null) {
			StartCoroutine (SendTexture (sendTexture));
		} else {
			Debug.LogWarning ("sendTexture not found");
		}
	}

	public IEnumerator SendTexture (Texture2D _texture)
	{
		string jsonString = "";

		// Create a Request Json
		GCVAPISample.Image image = new GCVAPISample.Image(_texture);
		List<Feature> features = new List<Feature>();
//		Feature feature = new Feature (FeatureType.TEXT_DETECTION, 5); // error from api server?
//		features.Add (feature);
		foreach (FeatureType _featureType in Enum.GetValues(typeof(FeatureType))) {
			Feature feature = new Feature (_featureType, 3);
			features.Add (feature);
		}
		ImageContext imageContext = new ImageContext ();
		AnnotateImageRequest _request = new AnnotateImageRequest (image, features, imageContext);
		GoogleCloudVisionApiRequest gcv = new GoogleCloudVisionApiRequest ();
		gcv.Add (_request);

		jsonString = JsonUtility.ToJson (gcv, true);
		Debug.Log (jsonString);

		// Create a header
		Dictionary<string, string> header = new Dictionary<string, string> ();
		header.Add ("Content-Type", "application/json; charset=UTF-8");

		byte[] postBytes = Encoding.Default.GetBytes (jsonString);

		WWW www = new WWW (API_ENDPOINT + API_KEY, postBytes, header);
		yield return www;
		if (!string.IsNullOrEmpty (www.error)) {
			Debug.LogError (www.error);
			Debug.Log (www.text);
		} else {
			Debug.Log (www.text);
			inputField.text = www.text;
			GoogleCloudVisionApiResponse googleCloudVisionApiResponse =
				(GoogleCloudVisionApiResponse) JsonUtility.FromJson (
					www.text,
					typeof(GoogleCloudVisionApiResponse));
			Debug.Log (googleCloudVisionApiResponse);
		}
	}
}
