using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEnterExitSystem : MonoBehaviour
{

    public MonoBehaviour CarController;
    public Transform Car;
    public Transform Player;
    public Transform PlayerSpawn;
    public Transform emergencySpawn;
    //public Vector3 offset = new Vector3(0, +2, 0);

    //[Header(“Cam”)]
    public GameObject PlayerCam;
    public GameObject CarCam;

   // public GameObject DriveUi;

    bool Candrive;



    // Start is called before the first frame update
    void Start()
    {
        CarController.enabled = false;
       // DriveUi.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && Candrive)  // Here After Click left button and trigger is true player is driving
        {
           
            CarController.enabled = true; // After Click F button Car Controller Script is enabled

            //DriveUi.gameObject.SetActive(false);

            // Here we parent Car with player
            Player.transform.SetParent(PlayerSpawn);
            Player.transform.position = PlayerSpawn.transform.position;
            Player.gameObject.SetActive(false);

            // Camera
            PlayerCam.gameObject.SetActive(false);
            CarCam.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
           

            CarController.enabled = false; // After Click G button Car Controller Script is disable


            // Here We Unparent the Player with Car
            Player.transform.SetParent(null);
            Player.transform.position = Player.transform.position;
            Player.gameObject.SetActive(true);

            // Here If Player Is Not Driving So PlayerCamera turn On and Car Camera turn off

            PlayerCam.gameObject.SetActive(true);
            CarCam.gameObject.SetActive(false);
        }
        if (Car.rotation.eulerAngles.z == 180f)
        {
            Player.transform.position = emergencySpawn.transform.position;
            Candrive = false;
            Player.transform.SetParent(null);
            Player.transform.position = Player.transform.position;
            Player.gameObject.SetActive(true);
        }
        if (Car.rotation.eulerAngles.z == -180f)
        {
            Player.transform.position = emergencySpawn.transform.position;
            Candrive = false;
            Player.transform.SetParent(null);
            Player.transform.position = Player.transform.position;
            Player.gameObject.SetActive(true);
        }
    }
   

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
           // DriveUi.gameObject.SetActive(true);
            Candrive = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
           // DriveUi.gameObject.SetActive(false);
            Candrive = false;
        }
    }
}
