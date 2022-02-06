using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    class ConcreteBuilderChild:Builder
    {
        private Sweets sweet = new Sweets();
        public override void BuildPackageSavory()
        {
            sweet.Add("Bundhi");
        
        }

        public override void BuildPackageSweet()
        {
            sweet.Add("GulabJamun");
            sweet.Add("Kova");
        }

        public override Sweets GetSweets()
        {
            return sweet;
        }
    }
}
