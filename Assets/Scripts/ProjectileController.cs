using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    #region Field Declarations

    public Vector2 projectileDirection;
    public float projectileSpeed;
    public bool isPlayers;

    #endregion

    #region Movement

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        transform.Translate(projectileDirection * Time.deltaTime * projectileSpeed, Space.World);

        if (ScreenBounds.OutOfBounds(transform.position))
        {
        	if (isPlayers)
        	{
        		PlayerController player = FindObjectOfType<PlayerController>();
        		player.EnableProjectile();
        	}
            Destroy(gameObject);
        }
    }

    #endregion
}
