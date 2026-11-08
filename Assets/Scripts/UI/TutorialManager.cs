using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject firstTutorialPopUp;
    public GameObject secondTutorialPopUp;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            firstTutorialPopUp.SetActive(false);
            secondTutorialPopUp.SetActive(true);
        }
    }

}
