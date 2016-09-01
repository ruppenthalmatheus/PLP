#include <conio.h>
#include <stdio.h>

int absoluto(int *n) {
	if (*n > 0) {
		return *n;
	}
	else if (*n < 0) {
		return ((*n) * -1);
	}
}

main() {
	
	int n = 0;
	
	for (int i = 1; i <= 10; i++) {
		
		printf("Informe um número inteiro: ");
		scanf("%i", &n);
	
		n=absoluto(&n);
	
		printf("O absoluto do número informado é: %i\n\n", n);
		
	}
	
	getche();
	
}


