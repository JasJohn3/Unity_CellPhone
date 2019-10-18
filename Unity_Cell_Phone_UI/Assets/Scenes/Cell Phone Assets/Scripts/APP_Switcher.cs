using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APP_Switcher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialPad;
    //other apps go below

    public void toggleObject(GameObject objectToToggle)
    {
        objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
    }
}
