﻿using UnityEngine;
using System.Collections;
using UMACharacterSystem;
using UMA;

public class ColorHandler : MonoBehaviour
{
    DynamicCharacterAvatar Avatar;
    string ColorName;
    OverlayColorData ColorValue;

    public void Setup(DynamicCharacterAvatar avatar, string colorName, OverlayColorData colorValue)
    {
        Avatar = avatar;
        ColorName = colorName;
        ColorValue = colorValue;
    }

    public void OnClick()
    {
        Avatar.SetColor(ColorName, ColorValue);
        Avatar.UpdateColors(true);
    }
}
