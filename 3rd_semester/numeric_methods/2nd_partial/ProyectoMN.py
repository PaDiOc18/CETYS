import numpy as np 

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
        #if (np.linalg.norm(x-x0,np.inf) < tol):  
        #    print("La cantidad de iteraciones Jacobi fueron: " + str(it)) 
        #    return x  
        x0 = np.copy(x) 
        print("Aproximación iteracion " + str(it) + ": " + "    x1=" + str(x[0]) + "    x2=" + str(x[1]) +  "   x3=" + str(x[2]) + "    x4=" + str(x[3]))
    #raise NameError("Iteraciones alcanzadas")

def gauss_seidel(A,b,x0,tol,N):  
    #Convertir a double 
    A = A.astype("double")  
    b = b.astype("double")  
    x0 = x0.astype("double")  
 
    n=np.shape(A)[0]  
    x = np.copy(x0)  
    it = 0   
    while (it < N):  
        it = it+1  
        for i in np.arange(n):  
            x[i] = b[i]  
            for j in np.concatenate((np.arange(0,i),np.arange(i+1,n))):  
                x[i] -= A[i,j]*x[j]  
            x[i] /= A[i,i]   
        #tolerancia  
        ##if (np.linalg.norm(x-x0,np.inf) < tol):  
            #print("La cantidad de iteraciones Gauss-Seidel fueron: " + str(it)) 
            #return x  
        x0 = np.copy(x)  
        print("Aproximación iteracion " + str(it) + ": " + "    x1=" + str(x[0]) + "    x2=" + str(x[1]) +  "   x3=" + str(x[2]) + "    x4=" + str(x[3]))
    #raise NameError("Iteraciones alcanzadas")


#Declaramos el Arreglo de tipo np, que sirve para hacer operaciones matriciales 
#Declaramos la Matriz A que solo contiene los elemntos con variables
"""
A = np.array([[4,-1,1,0],
              [4,-8,1,2],
              [-2,1,5,-1],
              [1,-4,3,10]])

#Declaramos la matriz de los términos independientes para aplicar la matriz aumentada en las funciones de arriba
B = np.array([[7],
              [-23],
              [16],
              [-15]])
"""
#Declaramos el punto desde donde el algortimo comenzará a Iterar
puntoInicial = np.array([0,2,1,1])

#Inicializamos el error a 0.000.. para alcanzar las 15 iteraciones
error = 0.00000001
#gauss_seidel(A,B,puntoInicial,error,15)
#jacobi(A,B,puntoInicial,error,15)




A = np.array([[7,21],
              [21,91]])

B = np.array([[29.4995472],
              [84.8193825]])

##Función que te saca la inversa de la Matriz A
AInversa = np.linalg.inv(A)

x = AInversa @ B 



print("La inversa de A es:")
print(AInversa)

print("Resultado de A' x B: ")

print(x)
