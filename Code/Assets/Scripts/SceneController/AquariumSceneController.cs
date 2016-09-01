﻿using System;
using UnityEngine;
using UnityEngine.UI;
using Soulgame.Util;
using System.Collections;
using System.Collections.Generic;

public class AquariumSceneController : BaseSceneController
{
    public Button BtnFisheries;

    public Button BtnShop;

    public BaseTank Tank;

	public AquariumSceneController ()
	{
		this.Level = Level.Aquarium;
	}

    public void OnBtnFisheries()
    {
        GameLog.Debug("OnBtnFisheries");
        //Main.Instance.GameStateManager.FireAction(GameAction.ToFisheries);
    }

    public void OnBtnShop() 
    {
        GameLog.Debug("OnBtnShop");
        //Main.Instance.GameStateManager.FireAction(GameAction.ToShop);
        Tank.IsActive = !Tank.IsActive;
    }

    public override void OnEnter() {
        base.OnEnter();
        Tank = new TankA(100,100,100);
        Tank.Init();
        
    }

    public override void OnUpdate() {
        Tank.OnUpdate();
        base.OnUpdate();
    }

}

