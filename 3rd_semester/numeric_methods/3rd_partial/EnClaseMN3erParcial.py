import numpy as np  
import math as m #desactivar si marca problemas
import sympy as sy
from numpy import array
x = sy.symbols("x")

def MetodoTrapecio(fa,a,b,n):
    print("Metodo trapecio:")
    h = (b-a)/n
    print(str(h))
    acum = 0
    for i in range(1,n):
        acum = acum + (2*float(sy.sympify(fa).subs(x,(a+(i*h)))))
        print("que tilt: " + str(a+(i*h)))
    acum2 = float(sy.sympify(fa).subs(x,a) + sy.sympify(fa).subs(x,b))
    print("acum es: " + str(acum))
    print("acum2 es: " + str(acum2))
    valor = float((acum + acum2)*(h/2)) 
    return valor

def SimpsonUnTercio(fa,a,b,n):
    print("Simpson 1/3:")
    h = (b-a)/n
    acumImpar = 0
    acumPar = 0
    Aux = float(sy.sympify(fa).subs(x,a) + sy.sympify(fa).subs(x,b))
    i = 1 
    while(i < n):
        if(i % 2 == 0):
            acumPar = acumPar + float(sy.sympify(fa).subs(x,(a+(i*h))))
        else:
            acumImpar = acumImpar + float(sy.sympify(fa).subs(x,(a+(i*h))))
        i = i + 1
    Total = (h/3)*(Aux + (4*acumImpar) + (2*acumPar))
    return Total

def SimpsonTresOctavos(fa,a,b,n):
    print("Simpson 3/8:")
    h = (b-a)/n
    acumImpar = 0
    acumPar = 0
    Aux = float(sy.sympify(fa).subs(x,a) + sy.sympify(fa).subs(x,b))
    i = 1
    while(i < n):
        if(i % 3 == 0):
            acumPar = acumPar + (2*float(sy.sympify(fa).subs(x,(a+(i*h)))))
        else:
            acumImpar = acumImpar + (3*float(sy.sympify(fa).subs(x,(a+(i*h)))))
        i = i + 1
    Total = ((3*h)/8)*(Aux +(acumPar+acumImpar))
    return Total
    
"""
expr1 = x * sy.log(x)
expr2 = (x + (2/x)) ** 2
expr3 = (x**2)/((4-x**2)**(0.5))
print("Punto 1:")
print("Punto 1a):")
print(str(SimpsonUnTercio(expr1,1,2,6)))
print(str(MetodoTrapecio(expr1,1,2,6)))
print(str(SimpsonTresOctavos(expr1,1,2,6)))
print("-------------------------------------------")
print("Punto 1b):")
print(str(SimpsonUnTercio(expr2,1,2,12)))
print(str(MetodoTrapecio(expr2,1,2,12)))
print(str(SimpsonTresOctavos(expr2,1,2,12)))
print("-------------------------------------------")
print("Punto 1c):")
print(str(SimpsonUnTercio(expr3,-1,3**0.5,18)))
print(str(MetodoTrapecio(expr3,-1,3**0.5,18)))
print(str(SimpsonTresOctavos(expr3,-1,3**0.5,18)))

print("______________________________________________________")
print("Punto 2:")
expr4 = 1/((1-x**2)**0.5)
expr5 = (sy.cos(x)/(sy.exp(x)))
print("Punto 2a):")
print(str(MetodoTrapecio(expr4,-0.999,0.999,198)))
print("Punto 2b):")
print(str(MetodoTrapecio(expr5,0,((5*sy.pi)/4),20))) #Me falta

print("______________________________________________________")
print("Punto 3:")
#expr6 = (1/3)*(x**3) + 1
#expr6derivada = x**2
expr6Arco = (1 + x**4)**(0.5)
print(str(SimpsonUnTercio(expr6Arco,0,2,20)))

print("______________________________________________________")
print("Punto 4:")
print("Resultado: 51.3126")

def funcion(x):
    f = (98 * m.asin(x/2))-(2*x*((49-x**2)**0.5))-((49*m.pi)/3)
    return f

def Biseccion(valorA,valorB):
    puntomitad = 0
    aux = abs(valorA - valorB)
    while(aux > 0.000001):
        puntomitad = (valorA + valorB)/2
        if(funcion(puntomitad)== 0):
            break
        if((funcion(valorA) * funcion(puntomitad))>0):
            valorA = puntomitad
        else:
            valorB = puntomitad
        aux = abs(valorA - valorB)
    return valorA

print(str(Biseccion(1.6,1.9)))

print("______________________________________________________")
Arreglo = array([5.8,7.3,6.9,8.7,8.8,10.3,14.5,15,10.4])
print("Punto 5:")
def MetodoTrapecio2():
    h = 1.86
    acum = 0
    for i in range(1,10):
        acum = acum + (2*Arreglo[i-1])
    valor = (acum)*(h/2) 
    return valor

def SimpsonUnTercio2():
    h = 1.86
    acumImpar = 0
    acumPar = 0
    Aux = 0
    i = 1 
    while(i < 10):
        if(i % 2 == 0):
            acumPar = acumPar + Arreglo[i-1]
        else:
            acumImpar = acumImpar + Arreglo[i-1]
        i = i + 1
    Total = (h/3)*(Aux + (4*acumImpar) + (2*acumPar))
    return Total

valorTrapecio = MetodoTrapecio2() * 4
valorSimpson1tercio = SimpsonUnTercio2() * 4

print("Metodo trapecio:")
print(str(valorTrapecio*7.48))
print("Simpson 1/3:")
print(str(valorSimpson1tercio*7.48))


print("________________________________________________")

"""
expr = sy.log(x)
expr2 = x /(Math.pow(sy.cos(x),2))
print(str(MetodoTrapecio(expr2,1,2,50)))