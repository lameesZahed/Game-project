// using UnityEngine;
// using UnityEngine.AI;

// public class LevelGenerator : MonoBehaviour
// {
//     public int width=10;
//     public int hieght=10;
//     public GameObject obstacle;
//     public GameObject player;
//     private bool playerspond = false;
//     public NavMeshSurface surface;
//     // public UnityEngine.AI.NavMeshAgent agent;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//                 generateLevel();
//                 surface.BuildNavMesh();


//     }

//     // Update is called once per frame
//     void Update()
//     {
//             for (int x = 0; x<= width; x+=2){
//         for(int y = 0; y<= hieght; y+=2){
//             if(Random.value > 0.7f){
//                 Vector3 pos = new Vector3(x-width/2f,1f, y-hieght/2f);
//                 Instantiate(obstacle,pos,obstacle.transform.rotation);
//             }
//             else if(!playerspond)
//             {
//                playerspond = true;
//                Vector3 pos = new Vector3(x-width/2f,1f, y-hieght/2f);
//                Instantiate(player,pos,player.transform.rotation);

//             }
//         }
//     }
//     }
// }
