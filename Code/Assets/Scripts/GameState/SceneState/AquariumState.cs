﻿using UnityEngine;
using System.Collections;

/// <summary>
/// 水族馆场景，该场景是游戏默认场景（第一次游戏默认场景是剧情场景）
/// </summary>
public class AquariumState : BaseGameSceneState
{

	public AquariumState(GameSceneStateManager stateManager) : base(stateManager)
	{
		this.BaseSceneController = new KitchenSceneController ();
	}

	public override Level LevelEnum
	{
		get
		{
			return Level.Aquarium;
		}
	}

    public override void OnEnter(BaseGameSceneState previousState, object data)
    {
        Debug.Log("OnEnter AquariumState");
        base.OnEnter(previousState, data);
    }

}
