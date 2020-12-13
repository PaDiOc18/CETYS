#include <iostream>
using namespace std;

/*
A = [38][27][43][3][9][82][10] <- k
nl(subarray - left) = [38][27][43][3] <- i
nr(subarray - right) = [9][82][10] <- j

i = 0, j = 0, k = 0 son los indeces y hay que inicializarlas a 0.
*/

void merge(int A[], int left, int mid, int right) {
	int i, j, k, nl, nr;
    nl = mid - left + 1; // <- tamaño izquierdo (subarray left)
    nr = right - mid; // <- tamaño derecho (subarray right)

	int* L = new int[nl], * R = new int[nr]; // crear matrices temporales. ERROR -> int L[nl], R[nr];

	// Copiar datos a matrices temporales L[] y R[].
	for (i = 0; i < nl; i++) {
		L[i] = A[left + i];
	}
	for (j = 0; j < nr; j++) {
		R[j] = A[mid + 1 + j];
	}

	// Merge las matrices temporales nuevamente en A[left..right].
	i = 0;  // Inicializa el index del primer subarray.
	j = 0; // Inicializa el index del segundo subarray.
	k = left; // Inicializa el index del subarray fusionado.

	while (i < nl && j < nr) {
		if (L[i] <= R[j]) {
			A[k] = L[i];
			i++;
		}
		else {
			A[k] = R[j];
			j++;
		}
		k++;
	}

	// Copia los elementos restantes de L[], si hay cualquiera.
	while (i < nl) {
		A[k] = L[i];
		i++;
		k++;
	}

	// Copia los elementos restantes de R[], si hay cualquiera.
	while (j < nr) {
		A[k] = R[j];
		j++;
		k++;
	}
}

// left es para el indice izquierdo y right es el indice derecho del subarreglo de A[] para ser ordenado
void mergeSort(int A[], int left, int right) {
	if (left < right) {
		// Igual que (left + right) / 2, pero evita el overflow para grandes indeces.
		int mid = left + (right - left) / 2; // Encuentra el punto medio para dividir la matriz en dos mitades. 

		//Ordenar primera y segunda mitades.
		mergeSort(A, left, mid); // Llama mergeSort por la primera mitad.
		mergeSort(A, mid + 1, right); // Llama mergeSort por la segunda mitad.
		merge(A, left, mid, right); // Combina las dos mitades ordenadas en los pasos mergeSort anteriores.
	}
}

void printArray(int A[], int size) {
	for (int i = 0; i < size; i++) {
		cout << A[i] << " ";
	}
}

int main()
{
	int n; 
	cout << "\t[Merge Sort]" << endl;
	cout << "\nDigite el numero de elementos: "; cin >> n;
	int* A = new int[n]; // ERROR -> int A[n];
	int A_size = sizeof(A) / sizeof(A[0]); // <- ¿tengo duda con eso?
	cout << "Digite cada elemento: " << endl;
	for (int i = 0; i < n; i++)
	{
		cin >> A[i];
	}
	cout << "\nArreglo antes de ser sorteado: ";
	printArray(A, n);
	mergeSort(A, 0, n - 1);
	cout << "\nArreglo despues de ser sorteado: ";
	printArray(A, n);

	delete[] A;
}
