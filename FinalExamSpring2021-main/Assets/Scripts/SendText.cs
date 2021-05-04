
using UnityEngine;
using UnityEngine.UI;

public class SendText : MonoBehaviour
{
    public static string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void SendName()
    {
        theName = inputField.GetComponent<Text>().text;
        //textDisplay.GetComponent<Text>().text = "Player: " + theName;
    }
}
