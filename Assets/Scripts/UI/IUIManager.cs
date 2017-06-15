﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIManager
{
    void InitButtonPanel();
    void InitAttackPanel();
    void InitDefendPanel();
    void InitResourcePanel();
    void InitInformationBoard();

    void AttackButtonClicked();
    void DefendButtonClicked();
    void ResourceButtonClicked();
    void ClosePanelButtonClicked();
}
