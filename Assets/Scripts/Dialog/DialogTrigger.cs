using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogBox;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogBox.SetActive(false);
        }
    }
}
