using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject canvas;
    private XRSTController LeftHandController;
    private XRSTController RightHandController;

    private void Start()
    {
        LeftHandController = LeftHand.GetComponent<XRSTController>();
        RightHandController = RightHand.GetComponent<XRSTController>();
    }

    private void Update()
    {
        /*Debug.Log("Left primary button: " + LeftHandController.PrimaryButton.Button);
        Debug.Log("Right primary button: " + RightHandController.PrimaryButton.Button);*/

        if (LeftHandController.PrimaryButton.Button || RightHandController.PrimaryButton.Button)
            canvas.SetActive(true);

        else
            canvas.SetActive(false);
    }
}
