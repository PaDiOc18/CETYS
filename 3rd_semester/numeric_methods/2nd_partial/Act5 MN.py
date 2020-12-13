import math
import numpy as np 

#Punto 1
A = np.array([[14,40.9],
     [40.9,157.41]])

B = np.array([[81.8],
     [302.3]])

print(B)
AInversa = np.linalg.inv(A)
print(AInversa)

x= AInversa @ B 
print("Resultado: ")

print(x)
print("_________________________________________________________________________________________________________")


#Punto 2
A = np.array([[9,3.869,2.3559],
     [3.869,2.3559,1.6085],
     [2.3559,1.6085,1.1702]])

B = np.array([[12.923],
     [5.3719],
     [3.0328]])

print(B)
AInversa = np.linalg.inv(A)
print(AInversa)

x= AInversa @ B 
print("Resultado: ")

print(x)
print("_________________________________________________________________________________________________________")

#Punto 3
A = np.array([[6,8.5],
     [8.5,15.05]])

B = np.array([[44.5776],
     [65.3905]])

print(B)
AInversa = np.linalg.inv(A)
print(AInversa)

x= AInversa @ B 
print("Resultado: ")

print(x)
