namespace ExemploComposite.Composite
{
    public abstract class Component
    {
        #region Métodos Compartilhados
        public abstract double CalculatePrice();

        public virtual void Add( Component c ) { }

        public virtual void Remove( Component c ) { }

        public virtual Component GetComponent( int i ) { return null; }
        #endregion
    }
}