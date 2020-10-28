using UnityEngine;
using System.Collections;

public class ScenarioBehaviour : MonoBehaviour
{
    public bool hundred;
    public bool seventyFive;
    public bool fifty;
    public bool twentyFive;
    public bool zero;

    public Texture off;
    public Texture on;

    private GameObject[] first;
    private GameObject[] second;
    private GameObject[] third;

    private GameObject[] speedFirst;
    private GameObject[] speedSecond;
    private GameObject[] speedThird;

    private GameObject speedDot;
    private GameObject speedDot2;
    private GameObject dot;
    private GameObject dot2;

    public GameObject path;
    public GameObject predict;

    public int changeScale = 100;
    public int speedScale = 10;

    public int change;

    public int truckSpeed;

    // Use this for initialization
    void Start()
    {
        hundred = true;
        seventyFive = false;
        fifty = false;
        twentyFive = false;
        zero = false;

        first = new GameObject[7];
        second = new GameObject[7];
        third = new GameObject[7];

        speedFirst = new GameObject[7];
        speedSecond = new GameObject[7];
        speedThird = new GameObject[7];

        firstInit();
        secondInit();
        thirdInit();

        //change = 3;
    }

    // Update is called once per frame
    void Update()
    {
        checkScale();
        
        if (hundred == true) // If the requested value is 100%
        {
            firstNumber(1);
            secondNumber(0);
            thirdNumber(0);
            path.active = false;
            predict.active = false;

        }
        else if (seventyFive == true) // If the requested value is 75%
        {
            firstNumber(0);
            secondNumber(7);
            thirdNumber(5);
            path.active = true;
            predict.active = true;
        }
        else if (fifty == true) // If the requested value is 50%
        {
            firstNumber(0);
            secondNumber(5);
            thirdNumber(0);
            path.active = false;
            predict.active = false;
        }
        else if (twentyFive == true) // If the requested value is 25%
        {
            firstNumber(0);
            secondNumber(2);
            thirdNumber(5);
            path.active = false;
            predict.active = false;
        }
        else if (zero == true) // If the requested value is 0%
        {
            firstNumber(0);
            secondNumber(0);
            thirdNumber(0);
            path.active = false;
            predict.active = false;
        }

        // Check speed variable
        // Check first number
        if (speedScale > 99)
        {
            firstNumberSpeed(1);
            truckSpeed = 100;
        }
        else
        {
            firstNumberSpeed(0);
        }

        // Check third number
        thirdNumberSpeed(0);


        // Check second number
        if ((speedScale >= 90) && (speedScale < 100))
        {
            secondNumberSpeed(9);
            truckSpeed = 90;
        }
        else if ((speedScale >= 80) && (speedScale < 90))
        {
            secondNumberSpeed(8);
            truckSpeed = 80;
        }
        else if ((speedScale >= 70) && (speedScale < 80))
        {
            secondNumberSpeed(7);
            truckSpeed = 70;
        }
        else if ((speedScale >= 60) && (speedScale < 70))
        {
            secondNumberSpeed(6);
            truckSpeed = 60;
        }
        else if ((speedScale >= 50) && (speedScale < 60))
        {
            secondNumberSpeed(5);
            truckSpeed = 50;
        }
        else if ((speedScale >= 40) && (speedScale < 50))
        {
            secondNumberSpeed(4);
            truckSpeed = 40;
        }
        else if ((speedScale >= 30) && (speedScale < 40))
        {
            secondNumberSpeed(3);
            truckSpeed = 30;
        }
        else if ((speedScale >= 20) && (speedScale < 30))
        {
            secondNumberSpeed(2);
            truckSpeed = 20;
        }
        else if ((speedScale >= 10) && (speedScale < 20))
        {
            secondNumberSpeed(1);
            truckSpeed = 10;
        }
        else 
        {
            secondNumberSpeed(0);
        }

        if(speedScale < 10)
        {
            truckSpeed = 0;
        }

    }

    void firstNumber(int number)
    {
        // Check scenario numbers
        if (number == 1)
        {
            // If the first number is 1 then show it
            first[0].renderer.material.mainTexture = on;
            first[1].renderer.material.mainTexture = off;
            first[2].renderer.material.mainTexture = off;
            first[3].renderer.material.mainTexture = on;
            first[4].renderer.material.mainTexture = off;
            first[5].renderer.material.mainTexture = off;
            first[6].renderer.material.mainTexture = off;
        }
        if (number == 0)
        {
            // If the first number is 0 then show it
            for (int a = 0; a < 6; a++)
            {
                first[a].renderer.material.mainTexture = on;
            }
            first[6].renderer.material.mainTexture = off;
        }

        dot.renderer.material.mainTexture = on;
        dot2.renderer.material.mainTexture = on;
        speedDot.renderer.material.mainTexture = on;
        speedDot2.renderer.material.mainTexture = on;
    }

    void firstNumberSpeed(int speed)
    {
        // Check speed numbers
        if (speed == 1)
        {
            // If the first number is 1 then show it
            speedFirst[0].renderer.material.mainTexture = on;
            speedFirst[1].renderer.material.mainTexture = off;
            speedFirst[2].renderer.material.mainTexture = off;
            speedFirst[3].renderer.material.mainTexture = on;
            speedFirst[4].renderer.material.mainTexture = off;
            speedFirst[5].renderer.material.mainTexture = off;
            speedFirst[6].renderer.material.mainTexture = off;
        }
        if (speed == 0)
        {
            // If the first number is 0 then show it
            for (int a = 0; a < 6; a++)
            {
                speedFirst[a].renderer.material.mainTexture = on;
            }
            speedFirst[6].renderer.material.mainTexture = off;
        }
    }

    void secondNumber(int number)
    {
        if (number == 2)
        {
            // If the first number is 2 then show it
            second[0].renderer.material.mainTexture = on;
            second[1].renderer.material.mainTexture = off;
            second[2].renderer.material.mainTexture = on;
            second[3].renderer.material.mainTexture = off;
            second[4].renderer.material.mainTexture = on;
            second[5].renderer.material.mainTexture = on;
            second[6].renderer.material.mainTexture = on;
        }
        if (number == 5)
        {
            // If the first number is 5 then show it
            second[0].renderer.material.mainTexture = off;
            second[1].renderer.material.mainTexture = on;
            second[2].renderer.material.mainTexture = on;
            second[3].renderer.material.mainTexture = on;
            second[4].renderer.material.mainTexture = on;
            second[5].renderer.material.mainTexture = off;
            second[6].renderer.material.mainTexture = on;
        }
        if (number == 7)
        {
            // If the first number is 7 then show it
            second[0].renderer.material.mainTexture = on;
            second[1].renderer.material.mainTexture = on;
            second[2].renderer.material.mainTexture = on;
            second[3].renderer.material.mainTexture = off;
            second[4].renderer.material.mainTexture = off;
            second[5].renderer.material.mainTexture = off;
            second[6].renderer.material.mainTexture = off;
        }
        if (number == 0)
        {
            // If the first number is 0 then show it
            second[0].renderer.material.mainTexture = on;
            second[1].renderer.material.mainTexture = on;
            second[2].renderer.material.mainTexture = on;
            second[3].renderer.material.mainTexture = on;
            second[4].renderer.material.mainTexture = off;
            second[5].renderer.material.mainTexture = on;
            second[6].renderer.material.mainTexture = on;
        }       
    }

    void secondNumberSpeed(int speed)
    {
        // Check speed variables
        if (speed == 0)
        {
            // If the first number is 0 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = off;
            speedSecond[5].renderer.material.mainTexture = on;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 1)
        {
            // If the first number is 1 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = off;
            speedSecond[3].renderer.material.mainTexture = off;
            speedSecond[4].renderer.material.mainTexture = off;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = off;
        }
        if (speed == 2)
        {
            // If the first number is 2 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = off;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = off;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = on;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 3)
        {
            // If the first number is 3 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = off;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 4)
        {
            // If the first number is 4 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = off;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = off;
        }
        if (speed == 5)
        {
            // If the first number is 5 then show it
            speedSecond[0].renderer.material.mainTexture = off;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 6)
        {
            // If the first number is 6 then show it
            speedSecond[0].renderer.material.mainTexture = off;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = on;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 7)
        {
            // If the first number is 7 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = off;
            speedSecond[4].renderer.material.mainTexture = off;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = off;
        }
        if (speed == 8)
        {
            // If the first number is 8 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = on;
            speedSecond[6].renderer.material.mainTexture = on;
        }
        if (speed == 9)
        {
            // If the first number is 9 then show it
            speedSecond[0].renderer.material.mainTexture = on;
            speedSecond[1].renderer.material.mainTexture = on;
            speedSecond[2].renderer.material.mainTexture = on;
            speedSecond[3].renderer.material.mainTexture = on;
            speedSecond[4].renderer.material.mainTexture = on;
            speedSecond[5].renderer.material.mainTexture = off;
            speedSecond[6].renderer.material.mainTexture = on;
        }
    }

    void thirdNumber(int number)
    {
        if (number == 5)
        {
            // If the first number is 5 then show it
            third[0].renderer.material.mainTexture = off;
            third[1].renderer.material.mainTexture = on;
            third[2].renderer.material.mainTexture = on;
            third[3].renderer.material.mainTexture = on;
            third[4].renderer.material.mainTexture = on;
            third[5].renderer.material.mainTexture = off;
            third[6].renderer.material.mainTexture = on;
        }
        if (number == 0)
        {
            // If the first number is 0 then show it
            third[0].renderer.material.mainTexture = on;
            third[1].renderer.material.mainTexture = on;
            third[2].renderer.material.mainTexture = on;
            third[3].renderer.material.mainTexture = on;
            third[4].renderer.material.mainTexture = off;
            third[5].renderer.material.mainTexture = on;
            third[6].renderer.material.mainTexture = on;
        }  
    }

    void thirdNumberSpeed(int speed)
    {
        // Check speed variables
        if (speed == 5)
        {
            // If the first number is 5 then show it
            speedThird[0].renderer.material.mainTexture = off;
            speedThird[1].renderer.material.mainTexture = on;
            speedThird[2].renderer.material.mainTexture = on;
            speedThird[3].renderer.material.mainTexture = on;
            speedThird[4].renderer.material.mainTexture = on;
            speedThird[5].renderer.material.mainTexture = off;
            speedThird[6].renderer.material.mainTexture = on;
        }
        if (speed == 0)
        {
            // If the first number is 0 then show it
            speedThird[0].renderer.material.mainTexture = on;
            speedThird[1].renderer.material.mainTexture = on;
            speedThird[2].renderer.material.mainTexture = on;
            speedThird[3].renderer.material.mainTexture = on;
            speedThird[4].renderer.material.mainTexture = off;
            speedThird[5].renderer.material.mainTexture = on;
            speedThird[6].renderer.material.mainTexture = on;
        }
    }

    void firstInit()
    {
        // Scenario variables
        first[0] = GameObject.Find("Timer001");
        first[1] = GameObject.Find("Timer002");
        first[2] = GameObject.Find("Timer003");
        first[3] = GameObject.Find("Timer004");
        first[4] = GameObject.Find("Timer005");
        first[5] = GameObject.Find("Timer006");
        first[6] = GameObject.Find("Timer007");
        dot = GameObject.Find("Timer023");
        dot2 = GameObject.Find("Timer024");

        // Speed variables
        speedFirst[0] = GameObject.Find("Timer101");
        speedFirst[1] = GameObject.Find("Timer102");
        speedFirst[2] = GameObject.Find("Timer103");
        speedFirst[3] = GameObject.Find("Timer104");
        speedFirst[4] = GameObject.Find("Timer105");
        speedFirst[5] = GameObject.Find("Timer106");
        speedFirst[6] = GameObject.Find("Timer107");
        speedDot = GameObject.Find("Timer123");
        speedDot2 = GameObject.Find("Timer124");
    }

    void secondInit()
    {
        // Scenario variables
        second[0] = GameObject.Find("Timer008");
        second[1] = GameObject.Find("Timer009");
        second[2] = GameObject.Find("Timer010");
        second[3] = GameObject.Find("Timer011");
        second[4] = GameObject.Find("Timer012");
        second[5] = GameObject.Find("Timer013");
        second[6] = GameObject.Find("Timer014");

        // Speed variables
        speedSecond[0] = GameObject.Find("Timer208");
        speedSecond[1] = GameObject.Find("Timer209");
        speedSecond[2] = GameObject.Find("Timer210");
        speedSecond[3] = GameObject.Find("Timer211");
        speedSecond[4] = GameObject.Find("Timer212");
        speedSecond[5] = GameObject.Find("Timer213");
        speedSecond[6] = GameObject.Find("Timer214");
    }

    void thirdInit()
    {
        // Scenario variables
        third[0] = GameObject.Find("Timer015");
        third[1] = GameObject.Find("Timer016");
        third[2] = GameObject.Find("Timer017");
        third[3] = GameObject.Find("Timer018");
        third[4] = GameObject.Find("Timer019");
        third[5] = GameObject.Find("Timer020");
        third[6] = GameObject.Find("Timer021");

        // Speed variables
        speedThird[0] = GameObject.Find("Timer315");
        speedThird[1] = GameObject.Find("Timer316");
        speedThird[2] = GameObject.Find("Timer317");
        speedThird[3] = GameObject.Find("Timer318");
        speedThird[4] = GameObject.Find("Timer319");
        speedThird[5] = GameObject.Find("Timer320");
        speedThird[6] = GameObject.Find("Timer321");
    }

    void checkScale()
    {
        if (GetComponent<ButtonPush>().upScale == true)
        {
            if (changeScale != 100)
            {
                changeScale = changeScale + 25;                
            }
        }

        if (GetComponent<ButtonPush>().upSpeedScale == true)
        {
            if (speedScale != 100)
            {
                speedScale = speedScale + 10;
            }
        }

        if (GetComponent<ButtonPush>().downScale == true)
        {
            if (changeScale != 0)
            {
                changeScale = changeScale - 25;           
            }
        }

        if (GetComponent<ButtonPush>().downSpeedScale == true)
        {
            if (speedScale != 0)
            {
                speedScale = speedScale - 10;
            }
        }

        if (changeScale == 100)
        {
            hundred = true;
            seventyFive = false;
            fifty = false;
            twentyFive = false;
            zero = false;
        }
        if (changeScale == 75)
        {
            hundred = false;
            seventyFive = true;
            fifty = false;
            twentyFive = false;
            zero = false;
        }
        if (changeScale == 50)
        {
            hundred = false;
            seventyFive = false;
            fifty = true;
            twentyFive = false;
            zero = false;
        }
        if (changeScale == 25)
        {
            hundred = false;
            seventyFive = false;
            fifty = false;
            twentyFive = true;
            zero = false;
        }
        if (changeScale == 0)
        {
            hundred = false;
            seventyFive = false;
            fifty = false;
            twentyFive = false;
            zero = true;
        }
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(900, 20, 1790), new Vector3(900, 20, 1000));
        Gizmos.DrawLine(new Vector3(900, 20, 1000), new Vector3(-250, 20, 1000));
        Gizmos.DrawLine(new Vector3(-250, 20, 1000), new Vector3(-250, 20, -500));
        Gizmos.DrawLine(new Vector3(-250, 20, -500), new Vector3(-1450, 20, -500));
        Gizmos.DrawLine(new Vector3(-1450, 20, -500), new Vector3(-1450, 20, -4000));
        Gizmos.DrawLine(new Vector3(-1450, 20, -4000), new Vector3(-1625, 20, -4000));
        Gizmos.DrawLine(new Vector3(-1625, 20, -4000), new Vector3(-1625, 20, -300));
        Gizmos.DrawLine(new Vector3(-1625, 20, -300), new Vector3(-400, 20, -300));
        Gizmos.DrawLine(new Vector3(-400, 20, -300), new Vector3(-400, 20, 1150));
        Gizmos.DrawLine(new Vector3(-400, 20, 1150), new Vector3(775, 20, 1150));
        Gizmos.DrawLine(new Vector3(775, 20, 1150), new Vector3(775, 20, 1750));
        Gizmos.DrawLine(new Vector3(775, 20, 1750), new Vector3(900, 20, 1790));
    }*/
}
