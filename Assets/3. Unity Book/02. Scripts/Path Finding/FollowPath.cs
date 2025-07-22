using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Path path;
    public float speed = 5f;
    public float mass = 5f;
    public bool isLooping = true;

    private float curSpeed;
    private int curPathIndex;
    private float pathLength;
    private Vector3 targetPoint;

    private Vector3 velocity;

    void Start()
    {
        pathLength = path.points.Length;
        curPathIndex = 0;
        velocity = transform.forward;
    }

    void Update()
    {
        curSpeed = speed * Time.deltaTime;
        targetPoint = path.GetPoint(curPathIndex);

        if (Vector3.Distance(transform.position, targetPoint) < path.radius)
        {
            if (curPathIndex < pathLength - 1)
                curPathIndex++;
            else if (isLooping)
                curPathIndex = 0;
            else
                return;
        }

        if (curPathIndex >= pathLength) // 루프가 없을 때
            return;
        if (curPathIndex >= pathLength - 1 && !isLooping)
            velocity += Steer(targetPoint, true);
        else
            velocity += Steer(targetPoint);
    }

    public Vector3 Steer(Vector3 target, bool isFinalPoint = false)
    {
        Vector3 targetDir = target - transform.position;
        float dist = targetDir.magnitude;
        
        targetDir = targetDir.normalized;

        if (isFinalPoint && dist < 10f)
            targetDir *= curSpeed * (dist / 10f);
        else
            targetDir *= curSpeed;
        
        Vector3 steeringForce = targetDir -velocity;
        Vector3 acceleration = steeringForce / mass;
        
        return acceleration;

    }
    
}
