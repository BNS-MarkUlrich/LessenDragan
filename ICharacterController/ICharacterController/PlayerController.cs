namespace ICharacterController
{
    public class PlayerController : ICharacterController
    {
        IInputDevice inputDevice;
        public PlayerController(IInputDevice inputDevice)
        {
            this.inputDevice = inputDevice;
        }
        public void Logic(float frametimer)
        {
            inputDevice.GetHorizontalAnalog();
        }

        public void SetCharacter(ICharacter character)
        {
            
        }
    }
}
