using UnityEngine;

public class ScreenModeChanger : MonoBehaviour
{
    public void SetScreenMode(bool is_fullscreen)
    {
        if (is_fullscreen)
        {
            Screen.SetResolution(Display.main.systemWidth, Display.main.renderingHeight,
                FullScreenMode.ExclusiveFullScreen);
        }
        else
        {
            Screen.SetResolution(1280, 720, FullScreenMode.ExclusiveFullScreen);
        }
    }
}
