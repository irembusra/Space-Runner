using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour {

    public Material[] skyboxes;
    private int count;
	// Use this for initialization
	void Start () {
        count = 0;
        RenderSettings.skybox = skyboxes[0];
	}
	
	// Update is called once per frame
	void Update () {

        count++;
        switch (count)
        {
            case 1000:
               RenderSettings.skybox = skyboxes[1];
                break;
            case 2000:
                RenderSettings.skybox = skyboxes[2];
                break;
            case 3000:
                RenderSettings.skybox = skyboxes[3];
                break;
            case 4000:
                RenderSettings.skybox = skyboxes[4];
                break;
            case 5000:
                RenderSettings.skybox = skyboxes[5];
                break;
            case 6000:
                RenderSettings.skybox = skyboxes[6];
                break;
            case 7000:
                count = 0;
                break;


        }


    }
	}

