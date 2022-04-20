using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {NoType, Type1, Type2, Type3, Type4, Type5}; // you can replace this with your own labels for the types of collectibles in your game!

	public CollectibleTypes CollectibleType; // this gameObject's type

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;

	public InputController inputController;

	// quando coletada
	public float distancetoMinku;
	public Collider minku, moeda;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		string estado = PlayerPrefs.GetString("coletado" + gameObject.name);
		if (estado == "true")
		{
			Destroy(gameObject);
		}
		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
		distancetoMinku = Vector3.Distance(moeda.transform.position, minku.transform.position);
		if (distancetoMinku < 5.0f && inputController.GetPlayerItem())
		{
			Collect();
			PlayerPrefs.SetString("coletado" + gameObject.name, "true");
		}
	}

	//void OnTriggerEnter(Collider other)
	//{
	//	if (other.tag == "Player" ) {
	//		Collect();
	//		transform.name = "coletado";
	//	}
	//}

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);

		//Below is space to add in your code for what happens based on the collectible type

		if (CollectibleType == CollectibleTypes.NoType) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type1) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type2) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type3) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type4) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type5) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}

		Destroy (gameObject);
	}
}
