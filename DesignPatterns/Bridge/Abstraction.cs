
namespace LearningCSharp.DesignPatterns.Bridge
{
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual void Dot()
        {
            this._implementation.Dot();
        }
        public virtual void Dash()
        {
            this._implementation.Dash();
        }
        public virtual void Space()
        {
            this._implementation.Space();
        }
    }
}
