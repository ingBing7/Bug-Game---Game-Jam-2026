using UnityEngine;

public class SceneNotifierTheSecond : MonoBehaviour
{
    public Task task;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        task.IsMother2Scene();
        Debug.Log("Mother 2 scene");
    }
}
