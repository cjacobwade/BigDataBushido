﻿using UnityEngine;
using System.Collections;

public class EventObject : GridObject 
{
	public GameEvent gameEvent;

	public override void Interact( Village village )
	{
		EventManager.instance.PlayEvent(gameEvent);
		GridManager.DeregisterGridObject(this);
		Destroy(gameObject);
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawIcon(transform.position, "EventObjectGizmo.png", true);
	}
}
