using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonControllerScript : MonoBehaviour
{
    public TMP_Text statusText;
    public GameObject printer;
    public GameObject printedPrefab;

    public void OnButtonPress()
    {
        statusText.text = "Working...";
        //printedPrefab.SetActive(false);
        Invoke("ShowFinishedMessageAndCreatePrefab", 5f);
    }

    
    private void ShowFinishedMessageAndCreatePrefab()
    {
        
        //printedPrefab.SetActive(true);

        GameObject printedObject = Instantiate(printedPrefab);
        printedObject.SetActive(true);
        printedObject.transform.position = new Vector3(printer.transform.position.x, (float) 0.5 * printer.transform.position.y, printer.transform.position.z);

        statusText.text = "Finished. Take things out";

    }
}
