using Best_Practices.ModelBuilders;
using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordEscapeCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetModel("Escape")
                .SetColor("Red")
                .SetBrand("Ford")
                .Build();
        }
    }
} 