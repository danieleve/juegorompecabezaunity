using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Transform[] Images;
    [SerializeField]
    private GameObject winText;
    public static bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Images[0].rotation.z == 0 &&
        Images[1].rotation.z == 0 &&
        Images[2].rotation.z == 0 &&
        Images[3].rotation.z == 0 &&
        Images[4].rotation.z == 0 &&
        Images[5].rotation.z == 0 &&
        Images[6].rotation.z == 0 &&
        Images[7].rotation.z == 0){
            youWin = true;
            winText.SetActive(true);
        }

    }
}
