using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example2
{
    class Builder1 : IBuilder {
        private Product product = new Product( );
        public void BuildPartA( ) {
            product.Add("PartA ");
        }

        public void BuildPartB( ) {
            product.Add("PartB ");
        }

        public Product GetResult( ) {
            return product;
        }
    }
}
