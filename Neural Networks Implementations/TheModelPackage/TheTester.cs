using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Networks_Implementations
{
    class TheTester
    {
        double v;
        double y;
        public TheTester(Form1 TheMainForm)
        {
            
            Test(TheMainForm);
        }
        private void Test(Form1 TheMainForm)
        {
            
            for(int i=0;i<TheMainForm.Data.NumberOfTestingInstances;i++)
            {
                v = TheMainForm.Model.Weights[0] + TheMainForm.Data.TrainingData[TheMainForm.class1, i, TheMainForm.Model.Feature1] * TheMainForm.Model.Weights[1] +
                        TheMainForm.Data.TrainingData[TheMainForm.class1, i, TheMainForm.Model.Feature2] * TheMainForm.Model.Weights[2];
                y = TheMainForm.Model.SignumActivationFunction(v);
            }
        }
    }
}
