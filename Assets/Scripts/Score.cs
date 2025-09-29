using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;  
    
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times:" + hits);
    }

}
