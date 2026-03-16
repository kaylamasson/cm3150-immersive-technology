using UnityEngine;

public class CradleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            GameEvents.current.SetCradleActive();
            
        }
    }
}
