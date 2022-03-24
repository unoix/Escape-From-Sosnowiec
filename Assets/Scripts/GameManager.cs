using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject player;
    [SerializeField] GameObject MovementButtonController;
    [SerializeField] Text moveButtonText;
    int currentTurn;
    bool isPlayerTurn;
    private bool MoveButtonState;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("There is more than one GameManager");
        }
    }
    private void Start()
    {
        MovementButtonController.SetActive(false);
    }
    public void MoveBtnPressed()
    {
       if(MovementButtonController.activeSelf == false)
       {
            MovementButtonController.SetActive(true);
            moveButtonText.text = "Cancel";
            Debug.Log("press");
       }
       else
       {
            MovementButtonController.SetActive(false);
            moveButtonText.text = "move";
            Debug.Log("Press");
       }
    }
}
