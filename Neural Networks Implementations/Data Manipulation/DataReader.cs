using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Networks_Implementations
{
    public class DataReader
    {
        int[, ,] TrainingData;
        int[, ,] TestingData;
        int NumberOfFeatures;
        int NumberOfClasses;
        int NumberOfTrainingInstances;
        int NumberOfTestingInstances;
        int NumberOfInstances;

        public DataReader()
        {
            NumberOfClasses = 3;
            NumberOfFeatures = 4;
            NumberOfInstances = 50;
            NumberOfTrainingInstances = 30;
            NumberOfTestingInstances = 20;
            TrainingData = new int[NumberOfClasses, NumberOfInstances, NumberOfFeatures];
            TestingData = new int[NumberOfClasses, NumberOfInstances, NumberOfFeatures];
            Reader();
        }
        private void Reader()
        {

        }
    }
}
