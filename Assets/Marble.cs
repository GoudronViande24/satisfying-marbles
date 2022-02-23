using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		GameObject marble = GameObject.Find("Marble");
		StartCoroutine(CreateClone(marble));
	}

	IEnumerator CreateClone(GameObject toClone)
	{
		if (remainingMarbles > 0)
		{
			float x = 0;
			float y = 3.72f;
			float z = 0;
			remainingMarbles--;
			Instantiate(toClone, new Vector3(x, y, z), toClone.transform.rotation);
			yield return new WaitForSeconds(.1f);
			StartCoroutine(CreateClone(toClone));
		}
	}

	public int remainingMarbles = 5;
}
