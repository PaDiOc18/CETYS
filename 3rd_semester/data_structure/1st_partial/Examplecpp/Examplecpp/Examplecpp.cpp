// Examplecpp.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
using namespace std;

class List {

	struct Nodo {
		Nodo *Anterior = nullptr;
		Nodo *Siguiente = nullptr;
		int Dato;

		Nodo(int Dato) {
			this->Dato = Dato;
		}
	};

	Nodo *raiz;

public:
	List(Nodo *raiz = nullptr) {
		this->raiz = raiz;
	}

	void insert(int datoNodo) {
		Nodo **base = &this->raiz;
		while (*base != nullptr) {
			if ((*base)->Dato < datoNodo) {
				base = &(*base)->Siguiente;
			}
			else {
				base = &(*base)->Anterior;
			}
		}
		*base = new Nodo(datoNodo);
	}


	void Imprimir() {
		Nodo **temp = &this->raiz;
		while (*temp != nullptr)
		{
			cout << (*temp)->Dato << ' ';
			cout << "Dir: " << &(*temp)->Dato << endl;
			temp = &(*temp)->Siguiente;
		}
		cout << endl;
	}

	void Search(int datillo) {
		int conta = 0;
		Nodo **base = &this->raiz;
		while (*base != nullptr) {
			if ((**base).Dato == datillo) {
				cout << "El numero esta en la posición: " << conta << endl;
				//cout<<"El numero tiene una dirección de memoria : "<<&base<<endl;
				*base = nullptr;
			}
			conta++;
			if (*base != nullptr) {
				base = &(*base)->Siguiente;
			}
		}
	}

	void Eliminar(int datillo2) {
		Nodo **base = &this->raiz;
		Nodo **aux = &this->raiz;
		while (*base != nullptr)
		{
			if ((**base).Dato == datillo2) {
				cout<<"Dir Erase: "<<&(*base)<<endl;
				aux = &(*base)->Anterior;
				base = &(*base)->Siguiente;
				aux = base;
			}
			base = &(*base)->Siguiente;
		}
	}

};
int main()
{
	List lista1;
	lista1.insert(1);
	lista1.insert(2);
	lista1.insert(3);
	lista1.insert(4);
	lista1.insert(5);
	lista1.Imprimir();

	int busco;
	cout << "Ingresa el número a buscar: " << endl;
	cin >> busco;
	lista1.Search(busco);

	int elimino;
	cout << "Ingresa el número a eliminar: " << endl;
	cin >> elimino;
	lista1.Eliminar(elimino);


	lista1.Imprimir();
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
