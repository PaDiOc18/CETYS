// Asignacion8MYP.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
#include <cmath>
#include <string>
#include <cstdint>

inline uint64_t regla_horner(std::string cadena);
inline uint64_t criterio_division(uint64_t llave);
inline uint64_t criterio_multiplicacion(uint64_t llave);
inline uint64_t criterio_fibonacci(uint64_t llave);

int main()
{
	std::string cadena{};
	std::cout << "String: ";
	std::cin >> cadena;
	std::cout << "Horner: " << regla_horner(cadena) << std::endl;

	uint64_t llave{};
	std::cout << "Numero: ";
	std::cin >> llave;
	std::cout << "Division: " << criterio_division(llave) << std::endl;
	std::cout << "Multiplicacion: " << criterio_multiplicacion(llave) << std::endl;
	std::cout << "Fibonacci: " << criterio_fibonacci(llave) << std::endl;
}

inline uint64_t regla_horner(std::string cadena)
{
	uint64_t res{};
	//{} Significa que inicializas un valor con un constructor vacio
	for (int i = cadena.length(); i >= 0; i--)
	{
		int ascii = int(cadena[i]); //Convierte a su valor ascii cada letra de la cadena
		res = (res)*10 + ascii;
		//std::cout << "Valor Ascii: " << ascii << std::endl;
		//https://www.math10.com/es/matematicas-universitarias/horner.html
	}
	return res;
}


inline uint64_t criterio_division(uint64_t llave)
{
	// table size = 549,755,813,888
	uint64_t m{ 412'637'104'417 }; //este
	return llave % m;
}

inline uint64_t criterio_multiplicacion(uint64_t llave)
{
	uint64_t m{ 59'755'813'543 }; //este
	uint64_t w{ 68'719'476'736 }; //este
	uint64_t a{ 94'143'178'827 }; //este
	return (a * llave) >> (w - m);
}

inline uint64_t criterio_fibonacci(uint64_t llave)
{
	float_t phi{ 5.0 / 3.0 };
	uint64_t num{ static_cast<uint64_t>(std::pow(2, 64)) - 1 };
	uint64_t shift{ static_cast<uint64_t>(num / phi) };
	return (llave * shift) >> 32;
}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
