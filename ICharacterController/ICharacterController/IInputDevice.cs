﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICharacterController
{
    public interface IInputDevice
    {
        float GetHorizontalAnalog();
        bool IsDown(GameButton button);
    }
}
