using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{

    bool isFirst = true; // Å‰‚Ìˆê‰ñ‚ğ”»’è‚·‚éƒtƒ‰ƒO

    void FixedUpdate()
    {
        // ˆê‰ñ‚¾‚¯ŒÄ‚Î‚ê‚é
        if (isFirst)
        {
            isFirst = false;  // ˆê‰ñ‚Í‚·‚¬‚½
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
            Vector3 force = new Vector3(0.0f, 5.0f, 0.0f);  // —Í‚ğİ’è
            rb.AddForce(force, ForceMode.Impulse);          // —Í‚ğ‰Á‚¦‚é
        }
    }
}