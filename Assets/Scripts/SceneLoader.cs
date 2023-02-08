using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AngelaChau;
namespace AngelaChau.SimpleLevelLoader
{
    public class SceneLoader : MonoBehaviour
    {
        // Need a feature that loads X scene when triggered is collided with
        [SerializeField] private int sceneToLoad;
        private void OnTriggerEnter(Collider other)
        {
            //If it is the PLAYER that has triggered this event...
            if (other.tag == "Player")
            {
                //LOAD THE SPECIFIC SCENE!
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

}
