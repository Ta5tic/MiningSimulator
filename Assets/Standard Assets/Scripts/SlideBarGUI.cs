using UnityEngine;
using System.Collections;

public class SlideBarGUI : MonoBehaviour 
{
    public Texture guiTex;

    public float x, y, width, height;

    // Variables to scale the gui
    private float screenWidth;
    private float screenHeight;
    
    // the gui scale ratio
    private float guiRatioX;
    private float guiRatioY;

    public int GUIdepth = 1;

    void Update()
    {
        // Find the Screen Width
        screenWidth = Screen.width;
        // Find the Screen Height
        screenHeight = Screen.height;

        // Determine the ratio for the X and Y values
        guiRatioX = screenWidth / 1920 * x;
        guiRatioY = screenHeight / 1080 * y;

        // If 'z' is pushed then display the background slide GUI
        if (Input.GetKeyDown("z"))
        {
            while (y > 451) /// Lowest Range of scaled y-axis for the gui
            {
                y--;
            }
        }
        else if(Input.GetKeyUp("z")) // If 'z' is released then hide the GUI
        {
            while (y < 751) /// Highest Range of scaled y-axis for the gui
            {
                y++;
            }
        }
    }

    void OnGUI()
    {
        GUI.depth = GUIdepth; 
        if (!guiTex)
        {
            //Debug.LogError("Assign a Texture in the inspector.");
            return;
        }

        GUI.DrawTexture(new Rect(guiRatioX, guiRatioY, screenWidth, screenHeight), guiTex, ScaleMode.ScaleToFit, true, 10.0f);
        /// Proper Display for Lower GUI:
        /// X:      2
        /// Y:      450
        /// Width:  600
        /// Height: 100
        /// Y Movement: 750 -> 450
    }
	
}
