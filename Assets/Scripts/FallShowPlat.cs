using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallShowPlat : MonoBehaviour
{
	public float fallTime = 0.5f;
	public float showTime = 2f;
	public BoxCollider collider;
	public MeshRenderer renderer;


	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			if (collision.gameObject.tag == "Player")
			{
				StartCoroutine(Fall(fallTime));
			}
		}
	}

	IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(fallTime);
		collider.enabled = false;
		renderer.enabled = false;
		yield return new WaitForSeconds(showTime);
        collider.enabled = true;
        renderer.enabled = true;
    }
}
