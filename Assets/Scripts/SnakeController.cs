using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SnakeController : MonoBehaviour
{

    [SerializeField]
    float MoveSpeed = 5;
    [SerializeField]
    float SteerSpeed = 180;
    [SerializeField]
    float BodySpeed = 5;
    [SerializeField]
    int Gap = 150;
    [SerializeField]
    int Points = 0;
    [SerializeField]
    TextMeshProUGUI pointText;

    public GameObject BodyPrefab;

    
    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionsHistory = new List<Vector3>();

   
    void Start()
    {

        
    }

    void OnTriggerEnter(Collider other)
    {
        string tagValue = other.gameObject.tag.ToLower();

        switch (tagValue)
        {
            case "point":
                
                Points++;
                pointText.text = string.Concat(Points.ToString("#0"),"/20");
                Crece();
                break;

            case "fail":
                int currentScene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentScene);
                break;

        
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        //Comportamiento serpiente
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);       
        PositionsHistory.Insert(0, transform.position);
        int index = 0;
        foreach (var body in BodyParts)
        {
            
            Vector3 point = PositionsHistory[Mathf.Clamp(index * Gap, 0, PositionsHistory.Count -1)];

            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * BodySpeed * Time.deltaTime;
           
            body.transform.LookAt(point);
            
             index++;
            
        }

       



    }

    private void Crece()
    {
        
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);
    }


    
}
