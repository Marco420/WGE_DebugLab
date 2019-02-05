using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCubeScript : MonoBehaviour {

    public GameObject cube;
    public Vector3 leftPosition;
    public Vector3 rightPosition;

    public void StartLerp()
    {
        cube.transform.position = leftPosition;
        StartCoroutine(LerpCube());
    }

    public void PrintDebugString()
    {
        Debug.Log(this.ToString());    
     }
    IEnumerator LerpCube()
    {
        float t = 0;

        while (t < 1)
        {
            t += Time.deltaTime;
            Debug.Log(t);
            cube.transform.position = Vector3.Lerp(leftPosition, rightPosition, t);
            if(t >=1)
            {
                cube.transform.position = rightPosition;
            }
            yield return null;
        }
    }

    public override string ToString()
    {
        string s;

        s = (cube ? "Cube positon = " + cube.transform.position: "Cube not instantiated ") + "\n"+ "Left Position = " + leftPosition + "\n" + "Right Position = " + rightPosition;
        return s;
    }

    //inseert code here:

}
