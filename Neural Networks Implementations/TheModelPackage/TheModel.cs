using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Networks_Implementations
{
    class TheModel
    {
        int epochs;
        int num_input;
        int num_output;
        int num_training;
        int bias;
        int Class1, Class2; //zero based
        int Feature1, Feature2 // zero based;
        double num_error;
        double eta;
        double[] error; //vector 1 X number of training
        double[] Weights; // vector of  ( number of inputs +1 ) x 1
        double[] MeanSquareError; // vector of 1 X  epochs


        public TheModel(Form1 TheMainForm)
        {
            this.epochs = TheMainForm.epochs;
            this.num_input = 2;
            this.num_output = 1;
            this.num_training = TheMainForm.Data.NumberOfTrainingInstances * this.num_input;
            this.bias = TheMainForm.bias;
            this.num_error = 0;
            this.eta = TheMainForm.eta;
            this.Class1 = TheMainForm.class1;
            this.Class2 = TheMainForm.class2;
            this.Feature1 = TheMainForm.FeatureOnX;
            this.Feature2 = TheMainForm.FeatureOnY;
            error = new double[num_training];
            Weights = new double[num_input + 1];
            MeanSquareError = new double[epochs];

            PreProcessing(TheMainForm);
        }
        private void PreProcessing(Form1  TheMainForm)
        {

        }
    }
}
