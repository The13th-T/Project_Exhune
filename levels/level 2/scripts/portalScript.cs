using UnityEngine;
using UnityEngine.SceneManagement;

public class portalScript : MonoBehaviour
{

    public string location;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(location);
    }
}
