using System.Collections.Generic;
using System.Linq;

namespace ExemploComposite.Composite
{
    public class Box : Component
    {
        #region Atributos
        private List<Component> Components {  get; set; }
        #endregion

        #region Métodos herdados
        public override double CalculatePrice()
        {
            double totalPrice = 0;
            foreach (var component in Components)
            {
                totalPrice += component.CalculatePrice();
            }

            return totalPrice;
        }

        public override void Add( Component c )
        {
            Components.Add( c );
        }

        public override void Remove( Component c )
        {
            Components.Remove( c );
        }

        public override Component GetComponent( int i )
        {
            return Components.ElementAt( i );
        }
        #endregion

        #region Construtor
        public Box() {
            Components = new List<Component>();
        }
        #endregion
    }
}