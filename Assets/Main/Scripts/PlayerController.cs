using UnityEngine;
using UnityEngine.SceneManagement; // عشان نقدر نعمل LoadScene

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public UnityEngine.AI.NavMeshAgent agent;
    public float moveSpeedMultiplier = 2f;
    public string enemyTag = "Enemy"; 
    public string gameOverSceneName = "GameOverScreen"; 
    private Animator animator;

    void Start()
    {
        agent.speed *= moveSpeedMultiplier;
    }
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(enemyTag))
        {
            Debug.Log("Game Over...");
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }


}
