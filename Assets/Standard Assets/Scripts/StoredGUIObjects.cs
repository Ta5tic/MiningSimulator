using UnityEngine;
using System.Collections;

public class StoredGUIObjects : MonoBehaviour 
{
    public Texture guiTex;

    public float x, y, width, height;

    // Variables to scale the gui
    private float screenWidth;
    private float screenHeight;

    // the gui scale ratio
    private float guiRatioX;
    public float guiRatioY;

    public int GUIdepth = 0;

    public GameObject[] objSelect;
    public int size = 10;
    public int i = 0;

    public Texture[] buttonTex;

    // Textures for the GUI Buttons
    public Texture truckTex;
    public Texture pitsTex;
    public Texture reservesTex;
    public Texture wasteTex;
    public Texture crusherTex;

    public GameObject changer;

    public bool[] cased;
    public bool[] newCase;

    // Oculus variable for texturing cubes
    public GameObject[] cubes;

    public GameObject guiChanger;

    void Start()
    {
        buttonTex = new Texture[size];
        cased = new bool[size];

        for (int a = 0; a < size; a++)
        {
            cased[a] = true;
            // Uncomment if you want the PSDI to work for Oculus
            //cubes[a].active = false;
        }
    }

    void Update()
    {
        // Find the Screen Width
        screenWidth = Screen.width;
        // Find the Screen Height
        screenHeight = Screen.height;       
    }

    void OnGUI()
    {
        GUI.depth = GUIdepth;

        // Enable Button drawing when data has been added to the 
        // Selections array.
        for (int j = 0; j < 5; j++)
        {
            if (GetComponent<ObjectSelection>().Selections[j] != null)
            {
                button(GetComponent<ObjectSelection>().Selections[j], j);
                //oculusCubes(GetComponent<ObjectSelection>().Selections[j], j);
            }
        }
        // If an object has been deleted then shuffle the gui around..
        if (GetComponent<ObjectSelection>().objectDeleted == true)
        {
            for (int k = 0; k < 4; k++)
            {
                // If a spot in the array is empty and the following spot isn't...
                // then we need to shuffle.
                if ((GetComponent<ObjectSelection>().Selections[k] == null) &&
                    (GetComponent<ObjectSelection>().Selections[k + 1] != null))
                {
                    button(GetComponent<ObjectSelection>().Selections[k + 1], k);
                    //oculusCubes(GetComponent<ObjectSelection>().Selections[k + 1], k);
                }
                if (k < 3)
                {
                    if ((GetComponent<ObjectSelection>().Selections[k] == null) &&
                    (GetComponent<ObjectSelection>().Selections[k + 2] != null))
                    {
                        button(GetComponent<ObjectSelection>().Selections[k + 2], k);
                        //oculusCubes(GetComponent<ObjectSelection>().Selections[k + 2], k);
                    }
                }
            }
        }

    }

    void button(GameObject obj, int buttonNumber)
    {
        switch (buttonNumber)
        {
            // Button One Position
            case 0:
                float zeroX, zeroY;
                zeroX = positionX(guiRatioX, 0);
                zeroY = positionY(guiRatioY);

                int text = findTexture(obj);
                switchTexture(text, buttonNumber);

                string buttonName = obj.name;
                GUI.Button(new Rect(zeroX, zeroY - 30, width, 30), buttonName);
                GUI.Button(new Rect(zeroX, zeroY, width, height), buttonTex[0]);

                break;
            // Button Two Position
            case 1:              
                float oneX, oneY;
                oneX = positionX(guiRatioX, 1);
                oneY = positionY(guiRatioY);

                int text1 = findTexture(obj);
                switchTexture(text1, buttonNumber);

                string buttonName1 = obj.name;
                GUI.Button(new Rect(oneX, oneY - 30, width, 30), buttonName1);

                GUI.Button(new Rect(oneX, oneY, width, height), buttonTex[1]);

                break;
            // Button Three Position
            case 2:                            
                float twoX, twoY;
                twoX = positionX(guiRatioX, 2);
                twoY = positionY(guiRatioY);

                int text2 = findTexture(obj);
                switchTexture(text2, buttonNumber);

                string buttonName2 = obj.name;
                GUI.Button(new Rect(twoX, twoY - 30, width, 30), buttonName2);

                GUI.Button(new Rect(twoX, twoY, width, height), buttonTex[2]);

                break;
            // Button Four Position
            case 3:                
                float threeX, threeY;
                threeX = positionX(guiRatioX, 3);
                threeY = positionY(guiRatioY);   

                int text3 = findTexture(obj);
                switchTexture(text3, buttonNumber);

                string buttonName3 = obj.name;
                GUI.Button(new Rect(threeX, threeY - 30, width, 30), buttonName3);

                GUI.Button(new Rect(threeX, threeY, width, height), buttonTex[3]);
                
                break;
            // Button Five Position
            case 4:              
                float fourX, fourY;
                fourX = positionX(guiRatioX, 4);
                fourY = positionY(guiRatioY); 

                int text4 = findTexture(obj);
                switchTexture(text4, buttonNumber);

                string buttonName4 = obj.name;
                GUI.Button(new Rect(fourX, fourY - 30, width, 30), buttonName4);

                GUI.Button(new Rect(fourX, fourY, width, height), buttonTex[4]);
                
                break;
            // Button Six Position
            case 5:
                cased[5] = GetComponent<ObjectSelection>().deleted[5];

                if (cased[5] == true)
                {
                    float fiveX, fiveY;
                    fiveX = positionX(guiRatioX, 5);
                    fiveY = positionY(guiRatioY); 
                 
                    int text5 = findTexture(obj);
                    switchTexture(text5, buttonNumber);

                    string buttonName5 = obj.name;
                    GUI.Button(new Rect(fiveX, fiveY - 30, width, 30), buttonName5);

                    GUI.Button(new Rect(fiveX, fiveY, width, height), buttonTex[5]);
                }
                    
                break;
            // Button Seven Position
            case 6:              
                cased[6] = GetComponent<ObjectSelection>().deleted[6];

                if (cased[6] == true)
                {
                    float sixX, sixY;
                    sixX = positionX(guiRatioX, 6);
                    sixY = positionY(guiRatioY);

                    int text6 = findTexture(obj);
                    switchTexture(text6, buttonNumber);

                    string buttonName6 = obj.name;
                    GUI.Button(new Rect(sixX, sixY - 30, width, 30), buttonName6);

                    GUI.Button(new Rect(sixX, sixY, width, height), buttonTex[6]);
                }
                    
                break;
            // Button Eight Position
            case 7:                
                cased[7] = GetComponent<ObjectSelection>().deleted[7];

                if (cased[7] == true)
                {
                    float sevenX, sevenY;
                    sevenX = positionX(guiRatioX, 7);
                    sevenY = positionY(guiRatioY);

                    int text7 = findTexture(obj);
                    switchTexture(text7, buttonNumber);

                    string buttonName7 = obj.name;
                    GUI.Button(new Rect(sevenX, sevenY - 30, width, 30), buttonName7);

                    GUI.Button(new Rect(sevenX, sevenY, width, height), buttonTex[7]);
                }
                    
                break;
            // Button Nine Position
            case 8:              
                cased[8] = GetComponent<ObjectSelection>().deleted[8];

                if (cased[8] == true)
                {
                    float eightX, eightY;
                    eightX = positionX(guiRatioX, 8);
                    eightY = positionY(guiRatioY);

                    int text8 = findTexture(obj);
                    switchTexture(text8, buttonNumber);

                    string buttonName8 = obj.name;
                    GUI.Button(new Rect(eightX, eightY - 30, width, 30), buttonName8);

                    GUI.Button(new Rect(eightX, eightY, width, height), buttonTex[8]);
                }
                    
                break;
            // Button Ten Position (+ Scrolling Arrow)
            case 9:                
                float nineX, nineY;
                nineX = positionX(guiRatioX, 9);
                nineY = positionY(guiRatioY);

                int text9 = findTexture(obj);
                switchTexture(text9, buttonNumber);

                string buttonName9 = obj.name;
                GUI.Button(new Rect(nineX, nineY - 30, width, 30), buttonName9);

                GUI.Button(new Rect(nineX, nineY, width, height), buttonTex[9]);
                
                // Now that there are 10 inputs now display a scrolling arrow..
                guiRatioX = screenWidth / 1920 * 1774;
                GUI.Button(new Rect(guiRatioX, guiRatioY, 50, height), "=>");
                break;
            default:
                break;

        }
    }

    void oculusCubes(GameObject obj, int buttonNumber)
    {
        switch (buttonNumber)
        {
            // Button One Position
            case 0:
                int text = findTexture(obj);
                switchTexture(text, buttonNumber);

                cubes[0].active = true;
                cubes[0].renderer.material.mainTexture = buttonTex[0];

                break;
            // Button Two Position
            case 1:
                int text1 = findTexture(obj);
                switchTexture(text1, buttonNumber);

                cubes[1].active = true;
                cubes[1].renderer.material.mainTexture = buttonTex[1];

                break;
            // Button Three Position
            case 2:
                int text2 = findTexture(obj);
                switchTexture(text2, buttonNumber);

                cubes[2].active = true;
                cubes[2].renderer.material.mainTexture = buttonTex[2];

                break;
            // Button Four Position
            case 3:
                int text3 = findTexture(obj);
                switchTexture(text3, buttonNumber);

                cubes[3].active = true;
                cubes[3].renderer.material.mainTexture = buttonTex[3];

                break;
            // Button Five Position
            case 4:
                int text4 = findTexture(obj);
                switchTexture(text4, buttonNumber);

                cubes[4].active = true;
                cubes[4].renderer.material.mainTexture = buttonTex[4];

                break;          
            default:
                break;

        }
    }

    void switchTexture(int switcher, int i)
    {
        switch (switcher)
            {
                case 1:
                    buttonTex[i] = truckTex;
                    break;
                case 2:
                    buttonTex[i] = pitsTex;
                    break;
                case 3:
                    buttonTex[i] = reservesTex;
                    break;
                case 4:
                    buttonTex[i] = wasteTex;
                    break;
                case 5:
                    buttonTex[i] = crusherTex;
                    break;
                default:
                    break;
            }
    }

    int findTexture(GameObject newbie)
    {
        // A walk through of objects to find what has been selected
        // and what texture to use for the GUI button
        if (newbie.transform.gameObject.tag == "Trucks")
        {
            // Truck ID = 1
            int truck = 1;
            return truck;
        }
        if (newbie.transform.gameObject.tag == "Pits")
        {
            // Pit ID = 2
            int pit = 2;
            return pit;
        }
        if (newbie.transform.gameObject.tag == "Reserves")
        {
            // Reserves ID = 3
            int reserves = 3;
            return reserves;
        }
        if (newbie.transform.gameObject.tag == "Wastes")
        {
            // Waste ID = 4
            int waste = 4;
            return waste;
        }
        if (newbie.transform.gameObject.tag == "Crushers")
        {
            // Crusher ID = 5
            int crusher = 5;
            return crusher;
        }

        return(0);
    }

    float positionX(float x, int arrNo)
    {
        if (arrNo == 0)
        {
            /// Proper Display for Lower GUI:
            /// X:      24
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 24;
        }
        else if (arrNo == 1)
        {
            /// Proper Display for Lower GUI:
            /// X:      199
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 199;
        }
        else if (arrNo == 2)
        {
            /// Proper Display for Lower GUI:
            /// X:      374
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 374;
        }
        else if (arrNo == 3)
        {
            /// Proper Display for Lower GUI:
            /// X:      549
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 549;
        }
        else if (arrNo == 4)
        {
            /// Proper Display for Lower GUI:
            /// X:      724
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 724;
        }
        else if (arrNo == 5)
        {
            /// Proper Display for Lower GUI:
            /// X:      899
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 899;
        }
        else if (arrNo == 6)
        {
            /// Proper Display for Lower GUI:
            /// X:      1074
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 1074;
        }
        else if (arrNo == 7)
        {
            /// Proper Display for Lower GUI:
            /// X:      1249
            /// Y:      855
            /// Width:  60
            /// Height: 60            
            /// x = screenWidth / 1920 * 1249;
        }
        else if (arrNo == 8)
        {
            /// Proper Display for Lower GUI:
            /// X:      1424
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 1424;
        }
        else if (arrNo == 9)
        {
            /// Proper Display for Lower GUI:
            /// X:      1599
            /// Y:      855
            /// Width:  60
            /// Height: 60
            x = screenWidth / 1920 * 1599;
        }
        return x;
    }

    float positionY(float y)
    {
        y = screenHeight / 1080 * 855;

        return y;
    }
}
