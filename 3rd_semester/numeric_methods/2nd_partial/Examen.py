import numpy as np
import pprint
import scipy
import scipy.linalg

def jacobi(A,b,x0,tol,N):  
    #Tomamos las matrices como doubles para los decimales
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
    n=np.shape(A)[0]#Tomamos el tamaño de la fila
    x = np.zeros(n) #Declaramos un arreglo del tamaño de las filas en 0 y Servirá para iterar sobre los resultados  
    it = 0  
    while (it < N):  
        it = it+1   #Le sumamos 1 a la iteración
        for i in np.arange(n):   #Un for que recorre la matriz
            x[i] = b[i]  
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  #Otro for que recorre la matriz aumentada
                x[i] -= A[i,j]*x0[j]  #Acumulador tipo resta que guarda las iteraciones y las multiplica por el vector inicial
            x[i] /= A[i,i]  #Acumulador que divide los valores de diagonal
        #Condicion de sobrepaso de la tolerancia
        if (np.linalg.norm(x-x0,np.inf) < tol):  
            print("La cantidad de iteraciones Jacobi fueron: " + str(it)) 
            return x  
        #Copiamos la matriz actual como la anterior
        x0 = np.copy(x) 
        #Solo te imprime en pantalla, no tiene mucha relevancia
        print("Aproximación iteracion " + str(it) + ": " + "    x1=" + str(x[0]) + "    x2=" + str(x[1]) +  "   x3=" + str(x[2]) + "    x4=" + str(x[3]))
    #raise NameError("Iteraciones alcanzadas")

def gauss_seidel(A,b,x0,tol,N):  
    #Tomamos las matrices como doubles para los decimales
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
 
    n=np.shape(A)[0]  #Tomamos el tamaño de la fila
    x = np.copy(x0)   #Creamos la matriz que nos ayudará a Iterar los resultados
    it = 0  #Inicialzamos contador de iteraciones
    while (it < N):  #Ciclo que nos ayudará a repetir hasta que alcance el número Maximo de iteraciones
        it = it+1   #Sumamo 1 al iterador
        for i in np.arange(n):  #For que recorre las filas
            x[i] = b[i]  # Usamos la fila de la matriz aumentada
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  #For que recorre las columnas
                x[i] -= A[i,j]*x[j]  #Acumulador de itera sobre el valor siguiente aproximado
            x[i] /= A[i,i]  #Acumulador que va diviendo por cada iteracion
        #Condicion de sobrepaso de la tolerancia
        #if (np.linalg.norm(x-x0,np.inf) < tol):  
            #print("La cantidad de iteraciones Gauss-Seidel fueron: " + str(it)) 
            #return x  
        x0 = np.copy(x)  
        #Solo muestra en pantalla, código no relevante
        print("Aproximación iteracion " + str(it) + ": " + "    x1=" + str(x[0]) + "   x2=" + str(x[1]) +  "     x3=" + str(x[2]) + "    x4=" + str(x[3]))
    #raise NameError("Iteraciones alcanzadas")

A = np.array([[4,-1,1,0],
              [4,-8,1,2],
              [-2,1,5,-1],
              [1,-4,3,10]])

#Matriz de solo los iguales
B = np.array([[7],
              [-23],
              [16],
              [-15]])

#Punto desde donde se inicia
Po = np.array([0,2,1,1])
error = 0.00000001
MaxItera = 15
print("Aproximaciones de Gauss Seidel: ")
gauss_seidel(A,B,Po,error,MaxItera)
print("Aproximaciones de Jacobi: ")
jacobi(A,B,Po,error,MaxItera)

"""
A = np.array([[10,51],
     [51,419]])

B = np.array([[27.96],
     [127.63]])

print("Matriz A:")
print(A)
print("Matriz B")
print(B)
print("______________________________")
AInversa = np.linalg.inv(A)
print("La inversa es de A es:")
print(AInversa)

print("______________________________")
x= AInversa @ B 
print("Resultado de B x A': ")

print(x)
"""
"""
A = np.array([ [1, 2, 4, 1], 
                [2, 8, 6, 4], 
                [3, 10, 8, 8], 
                [4, 12, 10, 6] ])

B = np.array([[21],
              [52],
              [79],
              [82]])

U = np.array([ [1,2,4,1], 
                [0,4,-2,2], 
                [0,0,-2,3], 
                [0,0,0,-6]])

L = np.array([ [1,0,0,0], 
            [2,1,0,0], 
            [3,1,1,0], 
            [4,1,2,1] ])
"""
"""
print("Matriz A: ")
print(A)
print("_________________________")
print("Matriz B: ")
print(B)
print("_________________________")
print("Matriz L: ")
print(L)
print("_________________________")


print("Matriz U: ")
print(U)
print("_________________________")


LInversa = np.linalg.inv(L)

y = LInversa @ B 



print("La inversa de U es:")
UInversa = np.linalg.inv(U)
print(UInversa)

x = UInversa @ y 
print("Resultado de U' x B: ")
print("La matriz x: ")


"""
"""
A = np.array([[1/10,1/4,1/20],
              [1/7.5,1/6,1/15],
              [1/15,1/3,1/40]])

B = np.array([[2.5],
              [3],
              [1.75]])

L = np.array([[0,0,0],
              [0,0,0],
              [0,0,0]])


print("Matriz Original n*n")
print(A)
#Declaramos las matrices de tipo float para mayor precisión
A = A.astype("float") 
L = L.astype("float") 
B = B.astype("float")

#Iteracion 1 
#Factor 1 =  PRIMER ELEMENTO FILA2 / PRIMER ELEMENTO FILA 1 
Factor1 = A[1,0]/A[0,0] 
#Factor 2 =  PRIMER ELEMENTO FILA3 / PRIMER ELEMENTO FILA 1 
Factor2 = A[2,0]/A[0,0]

#F2 = F2 - Factor1*F1
A[1] = A[1] - (1*Factor1 * A[0])
#F3 = F3 - Factor2*F1
A[2] = A[2] - (1*Factor2 * A[0])


print("Iteracion 1")
print("___________________-")
print("U:")
#Imprimimos la U (En este caso es A p
# porque estamos modificando la matriz A)
print(A)
#Ahora vamos construyendo la matriz L
L[0,0] = 1
L[1,0] = Factor1
L[2,0] = Factor2
print("L: ")
print(L)

#Iteracion 2

#Factor 3 = Tercera fila 2 elemento / 2da fila 2 elemento
Factor3 = A[2,1] / A[1,1]
print("Factor 3: " + str(Factor3))
#F3 = F3 - Factor3*F2
A[2] = A[2] - (1*Factor3 * A[1])
print("Iteracion 2")
print("___________________-")
print("U:")
print(A)

#Terminamos de construir L 
L[0,0] = 1
L[1,1] = 1
L[2,2] = 1
L[1,0] = Factor1
L[2,0] = Factor2
L[2,1] = Factor3
print("L: ")
print(L)

#Sacamos la matriz y multiplicando L' * B
y = np.linalg.inv(L) @ B 
print("y: ")
#Imprimimos Matriz y
print(y)

#Sacamos la matriz resultado multplicando U' * B
x = np.linalg.inv(A) @ y
print("x:")
#Imprimimos Matriz Resultado x
print(x)
"""