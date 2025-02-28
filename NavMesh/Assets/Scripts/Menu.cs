using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pinkHome;
    public GameObject blueHome;
    public GameObject whiteHome;
    public GameObject orangeHome;

    private int pinkHomeIndex = 0;
    private int blueHomeIndex = 3;
    private int orangeHomeIndex = 6;
    private int whiteHomeIndex = 9;

    public Camera[] cameras;

    public Transform[] homeLocs;

    public GameObject[] agentPrefabs;
    public GameObject spawnPoint;

    public void resetScene()
    {
        SceneManager.LoadScene("Production");
    }

    public void changeHomeLocations()
    {
        if (homeLocs.Length >= 11)
        {
            pinkHomeIndex = (pinkHomeIndex + 1) % 3 + 0;
            blueHomeIndex = (blueHomeIndex + 1) % 3 + 3;
            orangeHomeIndex = (orangeHomeIndex + 1) % 3 + 6;
            whiteHomeIndex = (whiteHomeIndex + 1) % 3 + 9;

            pinkHome.transform.position = homeLocs[pinkHomeIndex].position;
            blueHome.transform.position = homeLocs[blueHomeIndex].position;
            orangeHome.transform.position = homeLocs[orangeHomeIndex].position;
            whiteHome.transform.position = homeLocs[whiteHomeIndex].position;
        }
    }

    public void spawnAgents()
    {
        foreach (GameObject agentPrefab in agentPrefabs)
        {
            Instantiate(agentPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
    }

    public void changeCamera()
    {
        if (cameras.Length > 0)
        {
            Camera currentCamera = null;
            foreach (Camera cam in cameras)
            {
                if (cam.gameObject.activeInHierarchy)
                {
                    currentCamera = cam;
                    break;
                }
            }

            if (currentCamera != null)
            {
                currentCamera.gameObject.SetActive(false);
            }

            int currentCameraIndex = System.Array.IndexOf(cameras, currentCamera);
            int nextCameraIndex = (currentCameraIndex + 1) % cameras.Length;
            cameras[nextCameraIndex].gameObject.SetActive(true);
        }
    }
}
