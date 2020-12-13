#include <cmath>
#include <string>
#include <cstdint>
#include <iostream>

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
	for(int i = 0; i < cadena.length() - 1; i++)
	{
		int ascii = int(cadena[i]); 
		res += (ascii * std::pow(10, i));
	}
	return res;
}

inline uint64_t criterio_division(uint64_t llave)
{
	// table size = 549,755,813,888
	uint64_t m{ 412'637'104'417 };
	return llave % m;
}

inline uint64_t criterio_multiplicacion(uint64_t llave)
{
	uint64_t m{ 59'755'813'543};
	uint64_t w{ 68'719'476'736 };
	uint64_t a{ 94'143'178'827 };
	return (a * llave) >> (w - m);
}

inline uint64_t criterio_fibonacci(uint64_t llave)
{
	float_t phi{ 5.0/3.0 };
	uint64_t num{ static_cast<uint64_t>(std::pow(2, 64)) - 1};
	uint64_t shift{ static_cast<uint64_t>(num/phi) };
	return (llave * shift) >> 32;
}