
using System;

public class EventBroker 
{
	//public static Action GameEnded;
	public static Action PlayerHitByEnemy;
	public static Action ProjectileOutOfBounds;
	public static Action<int> EnemyDestroyed;
	public static Action<int> ScoreUpdateOnEnemyKill;
	public static void CallProjectileOutOfBounds()
	{
		if(ProjectileOutOfBounds != null) ProjectileOutOfBounds();

	}
}
