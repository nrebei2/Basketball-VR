using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace NewtonVR.Example
{
    public class ResetScene : MonoBehaviour
    {
        public void ResetTheScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            BallsTakenText.BallsTakenNumber = 0;
            BasketsText.NumberBaskets = 0;
            TimerText.TimerLeft = 120.0f;
            Builder.InstanceArr = new GameObject[100];
            Builder.number = 0;
        }
    }
}