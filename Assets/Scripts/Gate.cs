using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OpenGate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenGate(){
        animator.SetBool("Open", true);
    }

    private void CloseGate(){
        animator.SetBool("Open", false);
    }
}
