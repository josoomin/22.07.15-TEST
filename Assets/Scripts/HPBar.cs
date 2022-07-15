using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG3D
{
    public class HPBar : Unit
    {
        void Update()
        {
            _hpBar.fillAmount = _hp / _maxHP;
        }
    }
}