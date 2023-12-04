using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlActivitie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    public GameObject cube;
    public GameObject cyclinder;

    public Material red;
    public Material blue;
    public Material green;

    private Renderer sphereRenderer;
    private Renderer cubeRenderer;
    private Renderer cyclinderRenderer;


    private void Start()
    {
        sphereRenderer = sphere.GetComponent<Renderer>();
        cubeRenderer = cube.GetComponent<Renderer>();
        cyclinderRenderer = cyclinder.GetComponent<Renderer>();
    }

    public void SphereClicked()
    {

        if (sphere.activeInHierarchy == true)
        {
            sphere.SetActive(false);
        }
        else {
            cyclinder.SetActive(false);
            cube.SetActive(false);
            sphere.SetActive(true);
            Debug.Log("sphere Clicked");

        }
    }

    public void CubeClicked()
    {
        if (cube.activeInHierarchy == true)
        {
            cube.SetActive(false);
        }
        else
        {
            sphere.SetActive(false);
            cyclinder.SetActive(false);
            cube.SetActive(true);
            Debug.Log("cube Clicked");

        }
    }

    public void CyclinderClicked()
    {

        if (cyclinder.activeInHierarchy == true)
        {
            cyclinder.SetActive(false);
        }
        else {
            sphere.SetActive(false);
            cube.SetActive(false);
            cyclinder.SetActive(true);
            Debug.Log("Cyclinder Clicked");

        }
    }
    public void SelectBlue()
    {
        sphereRenderer.material = blue;
        cubeRenderer.material = blue;
        cyclinderRenderer.material = blue;
    }

    public void SelectRed()
    {
        sphereRenderer.material = red;
        cubeRenderer.material = red;
        cyclinderRenderer.material = red;
    }
    public void SelectGreen()
    {
        sphereRenderer.material = green;
        cubeRenderer.material = green;
        cyclinderRenderer.material = green;
    }


}
