namespace ICharacterController
{
    public interface ICharacter
    {
        void SetHorizontalDirection(float dx);
        void PerformAttack();
        void StartJump();
    }
}
