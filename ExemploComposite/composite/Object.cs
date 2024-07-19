namespace ExemploComposite.Composite
{
    public class Object : Component
    {
        #region Atributos
        private double Price { get; set; }
        #endregion

        #region Métodos herdados
        public override double CalculatePrice()
        {
            return Price;
        }
        #endregion

        #region Construtor
        public Object( double Price )
        {
            this.Price = Price;
        }
        #endregion
    }
}