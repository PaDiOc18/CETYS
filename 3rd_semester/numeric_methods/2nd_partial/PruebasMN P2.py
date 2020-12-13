import math
import numpy as np 


A = np.array([[7,5586],
     [5586,4482076]])

B = np.array([[11825],
     [9449575]])


print(B)
AInversa = np.linalg.inv(A)
print(AInversa)

x= AInversa @ B 
print("Resultado: ") 
print(x)