using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc : MonoBehaviour
{
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
		{
            bool isActive = !obj.activeSelf;
            Cursor.visible = isActive;
			obj.SetActive(isActive);
		}
    }
}
