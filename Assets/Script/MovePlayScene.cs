using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayScene : MonoBehaviour
{
    public FadeOutSceneLoader fadeOutSceneLoader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            fadeOutSceneLoader.CallCoroutine();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string yourTag = other.gameObject.tag;

        if (yourTag == "Sword")
        {
            fadeOutSceneLoader.CallCoroutine();
        }

    }

}
