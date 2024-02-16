using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResManager : MonoBehaviour
{

    public int width;
    public int height;

    public void SetWidth(int newWidth)
    {
        width = newWidth;
    }

    public void setHeight(int newHeight)
    {
        height = newHeight; 
    }

    public void SetResolution()
    {
        Screen.SetResolution(width, height, false);
    }
}
