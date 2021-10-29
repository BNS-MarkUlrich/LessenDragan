using System;
using System.Collections.Generic;
using System.Text;

namespace ICharacterController
{
    interface ICharacterController
    {

        void SetCharacter(ICharacter character);

        void Logic(float frametimer);
    }
}
