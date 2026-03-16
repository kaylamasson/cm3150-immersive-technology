using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] GameObject ActiveStrip; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActiveStrip.SetActive(false);
        GameEvents.current.eventCradleActive += OpenGate; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenGate(){
        ActiveStrip.SetActive(true); 
        animator.SetBool("Open", true);
    }

    private void CloseGate(){
        animator.SetBool("Open", false);
    }
}
