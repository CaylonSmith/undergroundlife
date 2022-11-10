using UnityEngine;

namespace Shinjingi
{
    [RequireComponent(typeof(Controller))]
    public class Move : MonoBehaviour
    {
        [SerializeField, Range(0f, 100f)] private float _maxSpeed = 4f;
        [SerializeField, Range(0f, 100f)] private float _maxAcceleration = 35f;
        [SerializeField, Range(0f, 100f)] private float _maxAirAcceleration = 20f;

        private Controller _controller;
        private Vector2 _direction, _desiredVelocity, _velocity;
        private Rigidbody2D _body;
        private Ground _ground;
        private bool isFacingRight;
        private float _maxSpeedChange, _acceleration;
        private bool _onGround;
        private float horizontal;
        private float moveInput;
        public float dashSpeed;
        public float dashTime;
        public float startDashTime;
        public int direction;

        public Animator animator;
        private void Awake()
        {
            _body = GetComponent<Rigidbody2D>();
            _ground = GetComponent<Ground>();
            _controller = GetComponent<Controller>();

            dashTime = startDashTime;
        }

        private void Update()
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            moveInput = Input.GetAxis("Horizontal");

            animator.SetFloat("speed", Mathf.Abs(horizontal));
          
            _desiredVelocity = new Vector2(horizontal, 0f) * Mathf.Max(_maxSpeed - _ground.Friction, 0f);
            Flip();


       



            if (direction == 0)
            {
                if (Input.GetKeyDown(KeyCode.RightShift))
                {
                    if (moveInput < 0)
                    {
                        direction = 1;

                    }
                    else if (moveInput > 0)
                    {
                        direction = 2;


                       
                    }
                }
            }
            else
            {
                //   dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    _body.velocity = Vector2.left * dashSpeed;
                   
                    direction -= 1;
                }
                else if (direction == 2)
                {
                    _body.velocity = Vector2.right * dashSpeed;
                  

                    direction -= 2;

                }

            }
        }

        private void FixedUpdate()
        {
            _onGround = _ground.OnGround;
            _velocity = _body.velocity;

            _acceleration = _onGround ? _maxAcceleration : _maxAirAcceleration;
            _maxSpeedChange = _acceleration * Time.deltaTime;
            _velocity.x = Mathf.MoveTowards(_velocity.x, _desiredVelocity.x, _maxSpeedChange);

            _body.velocity = _velocity;




           




        }



        private void Flip()
        {
            if (isFacingRight && horizontal > 0f || !isFacingRight && horizontal < 0f)
            {
                isFacingRight = !isFacingRight;
                transform.Rotate(0f, 180f, 0f);

            }
        }

        

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Elevator")
            {
                transform.parent = collision.gameObject.transform;

          
            }
        }



        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Elevator")
            {
                transform.parent = null;
            }
        }
    }


   


}
