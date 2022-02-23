using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		for (int i = multiplyByAmount -1; i > 0; i--)
		{
			Instantiate(collision.gameObject);
		}
	}

	public int multiplyByAmount = 2;
}
