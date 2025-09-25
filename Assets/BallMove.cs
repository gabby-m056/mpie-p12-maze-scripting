using UnityEngine;

public class BallMove : MonoBehaviour
{

    //get set properties
    public int verticalSpeed { get; set; }
    public int horizontalSpeed{ get; set; }
    public int x { get; set; }
    public int y{ get; set; }
    public bool moveUp { get; set; }
    public bool moveDown{ get; set; }
    public bool moveLeft { get; set; }
    public bool moveRight{ get; set; }
    //constructor
    public BallMove()
    {
        this.verticalSpeed = 10;
        this.horizontalSpeed = 10;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDown = true;
        }

        if (moveDown == true)
        {
            float movementVertical = Input.GetAxis("Vertical") * verticalSpeed;
            float movementHorizontal = Input.GetAxis("Horizontal") * horizontalSpeed;

            //movementVertical *= Time.deltaTime;
            //movementHorizontal *= Time.deltaTime;

            // Move translation along the object's z-axis
            transform.Translate(0, 0, movementVertical);

            // Rotate around our y-axis
            transform.Rotate(0, movementHorizontal, 0);
        }
            
    }
}
