// Pruebas.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
#include <vector>
//#include<bits/stdc++.h>




using namespace std;

void Merge(int A[], int p, int q, int r)
{

	int n1, n2, i, j, k;
	//size of left array=n1
	//size of right array=n2       
	n1 = q - p + 1;
	n2 = r - q;

	int L[n1], R[n2];
	//initializing the value of Left part to L[]
	for (i = 0; i < n1; i++)
	{
		L[i] = A[p + i];
	}
	//initializing the value of Right Part to R[]
	for (j = 0; j < n2; j++)
	{
		R[j] = A[q + j + 1];
	}
	i = 0, j = 0;
	//Comparing and merging them
	//into new array in sorted order 
	for (k = p; i < n1&&j < n2; k++)
	{
		if (L[i] < R[j])
		{
			A[k] = L[i++];
		}
		else
		{
			A[k] = R[j++];
		}
	}
	//If Left Array L[] has more elements than Right Array R[]
	//then it will put all the
	// reamining elements of L[] into A[]
	while (i < n1)
	{
		A[k++] = L[i++];
	}
	//If Right Array R[] has more elements than Left Array L[]
	//then it will put all the
	// reamining elements of L[] into A[]
	while (j < n2)
	{
		A[k++] = R[j++];
	}
}


void MergeSort(int arreglo[],int inicio, int fin) //inicio y fin, son los index.
{
	if (inicio < fin)
	{
		int mitad = (inicio + fin) / 2;
		MergeSort(arreglo, inicio, mitad);
		MergeSort(arreglo, mitad + 1, fin);
		Merge(arreglo, inicio, fin, mitad);
	}
	
}

// function to print the array
void printArray(int a[], int size)
{
	int i;
	for (i = 0; i < size; i++)
	{
		printf("%d ", a[i]);
	}
	printf("\n");
}


int main()
{
	std::cout << "Hello World!\n"; 
	int arr[] = { 32, 45, 67, 2, 7 };
	int len = sizeof(arr) / sizeof(arr[0]);

	printf("Given array: \n");
	printArray(arr, len);

	// calling merge sort
	MergeSort(arr, 0, len - 1);

	printf("\nSorted array: \n");
	printArray(arr, len);
	return 0;

}

// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
