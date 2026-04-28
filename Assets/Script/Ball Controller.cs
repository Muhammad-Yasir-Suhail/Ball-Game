using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private float movementHorizontal;
    private float movementVertical;
    public Rigidbody rigidbody;
    public static float speed = 5;
    public static int score = 0;
    public TMP_Text scoreText;
    public int maxScore;
    public GameObject levelCompletePanel;
    public float jumpSpeed;
    public bool isGrounded;
    public SoundManager soundManager;
   // public GameObject LevelFailedPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");

        Vector3 movementVector= new Vector3(movementHorizontal,0, movementVertical);
        rigidbody.AddForce(movementVector * speed);

       

        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) && isGrounded)
        {
            Jump();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            score++;
            
            other.gameObject.SetActive(false);
            
            scoreText.text = "score: " + score;
            
            soundManager.playCollectibleSound();
            
            
            

            //if (score >= maxScore)
            //{
            //    levelCompletePanel.SetActive(true);
            //}
        }
        else if (other.gameObject.CompareTag("Spike"))
        {
            
            score-=2;
            other.gameObject.SetActive(false);
            scoreText.text = "score: " + score;
            soundManager.playCollectibleSound();

            //if (score >= maxScore)
            //{
            //    levelCompletePanel.SetActive(true);
            //}
        }
        else if (other.gameObject.CompareTag("Flag"))
        {
            levelCompletePanel.SetActive(true);
            //LevelFailedPanel.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Bonus"))
        {

            score += 2;
            other.gameObject.SetActive(false);
            scoreText.text = "score: " + score;
            soundManager.playCollectibleSound();

            //if (score >= maxScore)
            //{
            //    levelCompletePanel.SetActive(true);
            //}
        }
        else if (other.gameObject.CompareTag("Finish"))
        {

           // score += 2;
            other.gameObject.SetActive(false);
            scoreText.text = "score: " + score;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            soundManager.playCollectibleSound();

            //if (score >= maxScore)
            //{
            //    levelCompletePanel.SetActive(true);
            //}
        }
    }

    public void Jump()
    {
        //rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpSpeed,rigidbody.velocity.z);
        float velocityFactor = rigidbody.velocity.magnitude * 0.2f + 1f;
        rigidbody.AddForce(Vector3.up * jumpSpeed * velocityFactor, ForceMode.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    
}
