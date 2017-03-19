# Neural-Networks-Implementations
#Implement the Perceptron learning algorithm on a single layer neural networks, 
which can be able to classify a stream of input data to one of a set of predefined classes using the iris dataset with accuracy +90%

#Objectives:
1. Draw Iris dataset
•  Iris dataset contains 150 samples (50 samples/class). Each sample consists of 4 features. 
The first part of task (1) is drawing all possible combinations of features like (X1, X2),
(X1, X3), (X1, X4), (X2, X3), (X2, X4), and (X3, X4) as shown in the following 

2.  Implement the Perceptron learning algorithm on a single layer neural networks, 
which can be able to classify a stream of input data to one of a set of predefined classes.
•  Use the iris data in both your training and testing processes. (Each class has 50 samples: 
train NN with the first 30 samples, and test it with the remaining 20 samples)
3.  After training, 
•  Draw a line that can discriminate between the two learned classes.
•  Test the classifier with the remaining 20 samples of each selected classes and find 
confusion matrix and compute overall accuracy.
-  Single layer neural network:
1. Input:
•  Select two features 
•  Select two classes (C1 & C2 or C1 & C3 or C2 & C3)
•  Enter learning rate (eta)
•  Enter number of epochs (m)
•  Add bias or not (Checkbox)
2. Initialization:
•  Number of features = 2. 
•  Number of classes = 2. 
•  Weights + Bias = small random numbers
3. Classification: 
•  Sample (single sample to be classified).
4. Workflow:
➢  Training Phase: (repeat the following m epochs)
Assuming that we have n training samples  {𝑠𝑏𝑛𝑝𝑚𝑒
𝑖
: 𝑗 = 1 → 𝒏}
•  Fetch features (x) of  𝑠𝑏𝑛𝑝𝑚𝑒
𝑖
, and its desired output (d)
•  Calculate the net value (v),
•  Calculate actual output (y) using signum activation function,
•  Calculate the error = d – y,
•  Update the weights (new weights = old weights + eta * error * x), note: old weights is  [
𝑐
𝑊1𝑗
𝑊1𝑘
]
➢  Draw line:  line equation is W1i * Xi + W1j * Xj + b = 0
➢  Testing Phase:
1.  Given a sample x
2.  Calculate the net value (v),
3.  Calculate actual output (y) using signum activation function,
4.  Output: y (Class ID).
➢  Evaluation: build the confusion matrix and overall accuracy
