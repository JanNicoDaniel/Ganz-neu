using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    //Variable, die die Bewegung der Wände bestimmt
    public static bool blueDown = false;
    public static bool greenDown = false;
    public static bool redDown = false;
    public static bool yellowDown = false;
    public static bool whiteDown = false;
    public static bool orangeDown = false;
    public static bool purpleDown = false;
    public static bool tealDown = false;
    //Variablen der Wände
    public static GameObject yellowWall;
    public static GameObject blueWall;
    public static GameObject greenWall;
    public static GameObject redWall;
    public static GameObject whiteWall;
    public static GameObject orangeWall1;
    public static GameObject orangeWall2;
    public static GameObject purpleWall1;
    public static GameObject purpleWall2;
    public static GameObject tealWall;
    public static void setTealDown(bool value)
    {
        tealDown = value;
    }
    public static void setPurpleDown(bool value)
    {
        purpleDown = value;
    }
    public static void setOrangeDown(bool value)
    {
        orangeDown = value;
    }
    public static void setRedDown(bool value)
    {
        redDown = value;
    }
    public static void setGreenDown(bool value)
    {
        greenDown = value;
    }
    public static void setYellowDown(bool value)
    {
        yellowDown = value;
    }
    public static void setBlueDown(bool value)
    {
        blueDown = value;
    }
    public static void setWhiteDown(bool value)
    {
        whiteDown = value;
    }
    void Start()
    {
        yellowWall = GameObject.Find("YellowWall");
        redWall = GameObject.Find("RedWall");
        greenWall = GameObject.Find("GreenWall");
        blueWall = GameObject.Find("BlueWall");
        whiteWall = GameObject.Find("WhiteWall");
        orangeWall1 = GameObject.Find("OrangeWall1");
        orangeWall2 = GameObject.Find("OrangeWall2");
        purpleWall1= GameObject.Find("PurpleWall1");
        purpleWall2 = GameObject.Find("PurpleWall2");
        tealWall= GameObject.Find("TealWall");
    }
    // Update is called once per frame
    void Update()
    {
        if (purpleDown)
        {
            Debug.Log("Pinke Wände geöffnet!");
            purpleWall1.transform.position = new Vector3(purpleWall1.transform.position.x, purpleWall1.transform.position.y - 1, purpleWall1.transform.position.z);
            purpleWall2.transform.position = new Vector3(purpleWall2.transform.position.x, purpleWall2.transform.position.y - 1, purpleWall2.transform.position.z);
            if (purpleWall1.transform.position.y < -23)
            {
                purpleDown = false;
            }
        }
        if (whiteDown)
        {
            Debug.Log("Weiße Wand geöffnet!");
            whiteWall.transform.position = new Vector3(whiteWall.transform.position.x, whiteWall.transform.position.y - 1, whiteWall.transform.position.z);
            if (whiteWall.transform.position.y < -23)
            {
                whiteDown = false;
            }
        }
        if (blueDown)
        {
            Debug.Log("Blaue Wand geöffnet!");
            blueWall.transform.position = new Vector3(blueWall.transform.position.x, blueWall.transform.position.y - 1, blueWall.transform.position.z);
            if (blueWall.transform.position.y < -23)
            {
                blueDown = false;
            }
        }
        if (greenDown)
        {
            Debug.Log("Grüne Wand geöffnet!");
            greenWall.transform.position = new Vector3(greenWall.transform.position.x, greenWall.transform.position.y - 1, greenWall.transform.position.z);
            if (greenWall.transform.position.y < -23)
            {
                greenDown = false;
            }
        }
        if (redDown)
        {
            Debug.Log("Rote Wand geöffnet!");
            redWall.transform.position = new Vector3(redWall.transform.position.x, redWall.transform.position.y - 1, redWall.transform.position.z);
            if (redWall.transform.position.y < -23)
            {
                redDown = false;
            }
        }
        if (yellowDown)
        {
            Debug.Log("Gelbe Wand geöffnet!");
            yellowWall.transform.position = new Vector3(yellowWall.transform.position.x, yellowWall.transform.position.y - 1, yellowWall.transform.position.z);
            if (yellowWall.transform.position.y < -23)
            {
                yellowDown = false;
            }
        }
        if (orangeDown)
        {
            Debug.Log("Orangene Wände geöffnet!");
            orangeWall1.transform.position = new Vector3(orangeWall1.transform.position.x, orangeWall1.transform.position.y - 1, orangeWall1.transform.position.z);
            orangeWall2.transform.position = new Vector3(orangeWall2.transform.position.x, orangeWall2.transform.position.y - 1, orangeWall2.transform.position.z);
            if (orangeWall1.transform.position.y < -23)
            {
                orangeDown = false;
            }
        }
        if (tealDown)
        {
            Debug.Log("Türkise Wand geöffnet!");
            tealWall.transform.position = new Vector3(tealWall.transform.position.x, tealWall.transform.position.y - 1, tealWall.transform.position.z);
            if (tealWall.transform.position.y < -23)
            {
                tealDown = false;
            }
        }
    }
}
