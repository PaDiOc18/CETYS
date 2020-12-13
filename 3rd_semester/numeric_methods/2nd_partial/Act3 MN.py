import numpy as np 
import math


abc = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]
abc2 = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26]

print("PUNTO 1: _________________________________________________________")
A = np.array([[1,2,3],
     [1,1,2],
     [0,1,2]])

cadena = "A"
i = 0
while cadena != abc[i]:
    i = i+1
#print(str(i+1))

B = np.array([[5],
     [14],
     [22]])

C = np.array([[9],
     [1],
     [4]])

D = np.array([[15],
     [12],
     [1]])

E = np.array([[18],
     [5],
     [19]])

R = A @ B
R2 = A @ C
R3 = A @ D
R4 = A @ E 
print(R)
print("______")
print(R2)
print("______")
print(R3)
print("______")
print(R4)

print("______")
print("______")
# INCISO B 

#INVERSA 
InversaA = np.linalg.inv(A)
print("Inversa es: ")
print(InversaA)

B2 = np.array([[85],
     [58],
     [39]])

C2 = np.array([[70],
     [45],
     [30]])

D2 = np.array([[73],
     [51],
     [37]])

E2 = np.array([[91],
     [57],
     [53]])

R5 = InversaA @ B2
R6 = InversaA @ C2
R7 = InversaA @ D2
R8 = InversaA @ E2

print(R5)
print("______")
print(R6)
print("______")
print(R7)
print("______")
print(R8)

#Punto 2 Actividad 6
print("PUNTO 2: _________________________________________________________")
MatrizA = np.array([[math.cos(math.pi/6),-1*math.sin(math.pi/6)],
     [math.sin(math.pi/6),math.cos(math.pi/6)]])

#print(MatrizA)
u = np.array([[1],
     [1]])

Res = MatrizA @ u
print("Normal A*U")
print(Res)
print("______")

Res2 = MatrizA @ MatrizA @ u
print("Cuadrado A**2 * u")
print(Res2)
print("______")


InversaMatrizA = np.linalg.inv(MatrizA)
print(InversaMatrizA)
Res3 = InversaMatrizA @ u
print("Inversa A**-1 * u")
print(Res3)

#Punto 3
#Matriz sin los iguales
print("PUNTO 3: _________________________________________________________")

A = np.array([[10,12,15],
              [6,8,12],
              [12,12,18]])

#Matriz de solo los iguales
B = np.array([[960],
              [660],
              [1080]])

#Metodo de la matriz inversa
#A*X = B
#AI * A *X = AI * B
# X = AI * B
print("Matriz Normal: ")
print(A)
print("Matriz Inversa: ")
print(np.linalg.inv(A))
print("INVERSA DE A por B")
X = np.linalg.inv(A) @ B
print("Resultado: ")
print(X)