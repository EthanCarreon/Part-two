using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{

    public GameObject options;
    public void openOptions()
    {
        options.SetActive(true);
    }

    public void closeOptions()
    {
        options.SetActive(false);
    }
}
