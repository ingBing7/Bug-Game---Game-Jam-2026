using UnityEngine;

public class SceneNotifier2 : MonoBehaviour
{

    public Task task;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        task.IsMotherScene();
    }
}
