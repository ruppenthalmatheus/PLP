#include <conio.h>
#include <stdio.h>

int maiorNumero(int *a, int *b) {
	if (*a > *b) {
		return (*a);
	}else if (*b > *a) {
		return (*b);
	}else{
		return (-1);
	}
}

main() {
	
	int a = 0;
	int b = 0;
	int maior = 0;
	
	for (int i = 1; i <= 5; i++) {
		do {
			printf("Informe um n�mero positivo: ");
			scanf("%i", &a);
			if (a < 0) {
				printf("O n�mero deve ser positivo!\n\n");
			}
		}while (a < 0);
		
		do {
			printf("Informe um segundo n�mero positivo: ");
			scanf("%i", &b);
			if (b < 0) {
				printf("O n�mero deve ser positivo!\n\n");
			}
		}while (b < 0);
		
		maior=maiorNumero(&a, &b);
		
		if (maior != -1) {
			printf("\nO maior elemento �: %i\n\n", maior);
		}else{
			printf("\nOs numeros sao iguais!\n\n");
		}
		
	}
	
}
