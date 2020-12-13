import numpy as np

A = np.array([[3,1,1],
              [3,6,2],
              [3,3,7]])

#Matriz de solo los iguales
B = np.array([[1],
              [0],
              [4]])

guess = np.array([0,0,0])


def jacobi(A,b,x0,tol,N):  
    #preliminares  
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
 
    n=np.shape(A)[0]  
    x = np.zeros(n)  
    it = 0  
    while (it < N):  
        it = it+1   
        for i in np.arange(n):  
            x[i] = b[i]  
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  
                x[i] -= A[i,j]*x0[j]  
            x[i] /= A[i,i]  
        #tolerancia  
        if (np.linalg.norm(x-x0,np.inf) < tol):  
            print("La cantidad de iteraciones Jacobi fueron: " + str(it)) 
            return x  
        x0 = np.copy(x) 
        print(x0)
    #raise NameError("Iteraciones alcanzadas")

def gauss_seidel(A,b,x0,tol,N):  
    #Convertir a double 
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
 
    n=np.shape(A)[0]  
    x = np.copy(x0)  
    it = 0  
    #iteracoes  
    while (it < N):  
        it = it+1  
        #iteracao de Jacobi  
        for i in np.arange(n):  
            x[i] = b[i]  
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  
                x[i] -= A[i,j]*x[j]  
            x[i] /= A[i,i]  
            #print(x[i],A[i,i])  
        #tolerancia  
        if (np.linalg.norm(x-x0,np.inf) < tol):  
            print("La cantidad de iteraciones Gauss-Seidel fueron: " + str(it)) 
            return x  
        x0 = np.copy(x)  
        print(x0)
    #raise NameError("Iteraciones alcanzadas")
    
def gauss_seidel2(A,b,x0,tol,N):  
    #Convertir a double 
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
 
    n=np.shape(A)[0]  
    x = np.copy(x0)  
    it = 0  
    #iteracoes  
    while (it < N):  
        it = it+1  
        #iteracao de Jacobi  
        for i in np.arange(n):  
            x[i] = b[i]  
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  
                x[i] -= A[i,j]*x[j]  
            x[i] /= A[i,i]  
            #print(x[i],A[i,i])  
        #tolerancia  
        #if (np.linalg.norm(x-x0,np.inf) < tol):   
        x0 = np.copy(x)  
        print(x0)


gauss_seidel(A,B,guess,0.0001,50)
jacobi(A,B,guess,0.0001,50)

print("_______________________________________________________________________________________")
print("15 Iteraciones Jacobi: ")

jacobi(A,B,guess,0.0001,15)
print("15 Iteraciones Seidel")
gauss_seidel2(A,B,guess,0.0001,15)


#PUNTO 2 a
print("Punto 2")
print("______________________________________________________________________________________")
A = np.array([[10,12,15],
              [6,8,12],
              [12,12,18]])

L = np.array([[0,0,0],
              [0,0,0],
              [0,0,0]])


print("Matriz Original n*n")
print(A)
A = A.astype("float") 
L = L.astype("float") 
#Iteracion 1 
Factor1 = A[1,0]/A[0,0]
Factor2 = A[2,0]/A[0,0]
#Encontramos U

#F2 = F2 - Factor1*F1
A[1] = A[1] - (1*Factor1 * A[0])
#F3 = F3 - Factor2*F1
A[2] = A[2] - (1*Factor2 * A[0])


print("Iteracion 1")
print("___________________-")
print("U:")
print(A)
L[0,0] = 1
L[1,0] = Factor1
L[2,0] = Factor2
print("L: ")
print(L)



#Iteracion 2
#F3 = F3 - Factor3*F2
Factor3 = A[2,1] / A[1,1]
print("Factor 3: " + str(Factor3))
#print("Factor 3: " + Factor3)
A[2] = A[2] - (1*Factor3 * A[1])
print("Iteracion 2")
print("___________________-")
print("U:")
print(A)4
L[0,0] = 1
L[1,1] = 1
L[2,2] = 1
L[1,0] = Factor1
L[2,0] = Factor2
L[2,1] = Factor3
print("L: ")
print(L)


print("__________________________________________________________________________________________")
print("Punto b")

#Punto 2 b

A = np.array([[2,3,4],
              [1,3,2],
              [1,3,1]])

L = np.array([[0,0,0],
              [0,0,0],
              [0,0,0]])

print("Matriz Original n*n")
print(A)
A = A.astype("float") 
L = L.astype("float") 
#Iteracion 1 
Factor1 = A[1,0]/A[0,0]
Factor2 = A[2,0]/A[0,0]
#Encontramos U

#F2 = F2 - Factor1*F1
A[1] = A[1] - (1*Factor1 * A[0])
#F3 = F3 - Factor2*F1
A[2] = A[2] - (1*Factor2 * A[0])


print("Iteracion 1")
print("___________________-")
print("U:")
print(A)
L[0,0] = 1
L[1,0] = Factor1
L[2,0] = Factor2
print("L: ")
print(L)



#Iteracion 2
#F3 = F3 - Factor3*F2
Factor3 = A[2,1] / A[1,1]
print("Factor 3: " + str(Factor3))
#print("Factor 3: " + Factor3)
A[2] = A[2] - (1*Factor3 * A[1])
print("Iteracion 2")
print("___________________-")
print("U:")
print(A)
L[0,0] = 1
L[1,1] = 1
L[2,2] = 1
L[1,0] = Factor1
L[2,0] = Factor2
L[2,1] = Factor3
print("L: ")
print(L)


















"""
k = np.diag(A) ##para la diagonal
print(k)
"""
