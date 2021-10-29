using System;

namespace ICharacterController
{
    public class CPUController : ICharacterController
    {
        ICharacter character;
        Random random = new Random();
        public void SetCharacter(ICharacter character)
        {
            this.character = character;
            // do something with Random number.
        }
        public void Logic(float frametimer)
        {

        }
    }
}
