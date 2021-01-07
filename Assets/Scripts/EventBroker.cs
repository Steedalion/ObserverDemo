
using System;

public class EventBroker 
{
	public static Action ProjectileOutOfBounds;
	public static void CallProjectileOutOfBounds()
	{
		if(ProjectileOutOfBounds != null) ProjectileOutOfBounds();

	}
}
