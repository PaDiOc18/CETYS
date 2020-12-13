from tkinter import * 
import matplotlib.pylab as plt
import numpy as np

Ventana1 = Tk()
Ventana1.title("Integración Numérica")

miFrame = Frame(Ventana1,width=500,height=500)
miFrame.pack()

var1 = StringVar()
var1 = "Hola mundo"
miLabel = Label(miFrame,text=var1)
miLabel.place(x=50,y=50)
#e = Entry()
def helloCallBack():
    var1 = "QUE PEDO"

#Ventana1.config(bg="yellow") #Cambiar color de fondo
k = Button(Ventana1, text="Click me!", command=helloCallBack)
k.place(x=0,y=20)
Ventana1.mainloop()

#Width Height
#Ventana1.resizable(0,0)
"""
x = np.arange(0,10,0.1)
y = x*np.cos(x)

plt.plot(x,y)
plt.xlabel('x')
plt.ylabel('y')
plt.title('Lab DLS')
plt.show()
"""