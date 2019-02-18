using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{

    public void ChangeToPlayGame(int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);

    }

}

