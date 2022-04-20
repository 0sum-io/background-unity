using UnityEngine;

// Generate a screenshot and save to disk with the name Screenshot.png.
public class Screenshot : MonoBehaviour
{
    void OnMouseDown()
    {
        print("Screenshot");
        ScreenCapture.CaptureScreenshot("Screenshot");
    }
}