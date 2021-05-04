using UnityEngine;
using UnityEngine.UI;

public class Livesdropdown : MonoBehaviour
{
    public static int lives = 1;
    public Dropdown noSelected;

    void Update()
    {
        switch (noSelected.value) {
            case 1:
                lives = 1;
                break;
            case 2:
                lives = 2;
                break;
            case 3:
                lives = 3;
                break;
            case 4:
                lives = 4;
                break;
            case 5:
                lives = 5;
                break;
            case 6:
                lives = 6;
                break;
            case 7:
                lives = 7;
                break;
            case 8:
                lives = 8;
                break;
            case 9:
                lives = 9;
                break;
            default:
                lives = 1;
                break;

                }
    }
}
