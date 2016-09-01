#include <conio.h>
#include <stdio.h>

int lePositivo() {
	int a = 0;
	
	do {
		printf("Informe um numero positivo: ");
		scanf("%i", &a);
		if (a < 0) {
			printf("O numero deve ser positivo!\n\n");
		}
	}while (a < 0);
		
	return (a);
}

int somatorio(int *n) {
	
	int total = 0;
	int x = *n;
	
	for (int i = 1; i <= *n; i++) {
		total=total+i;
	}
	
	return (total);
}

main() {
	
	int x = 0;
	int totalSoma = 0;
	
	for (int i = 1; i <= 5; i++) {
		x=lePositivo();
		totalSoma = somatorio(&x);
		printf("A soma eh: %i\n\n", totalSoma);
	}
	
}
