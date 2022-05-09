package Desafio;

public class Desafio01 {

	public static void main(String[] args) {
		int numeroRevertido = 0;
		int somaNumeros = 0;
		int numero = 1;
		while (numeroRevertido < 100) {
			
			numeroRevertido = calculaNumeroInverso(numero);
			somaNumeros = numero + numeroRevertido;

			if (somaNumeros % 2 != 0 && numeroRevertido != -1) {
				System.out.println(numero);
			}
			numero++;
		}
	}

	public static int calculaNumeroInverso(int num) {
		int i = 0;

		while (num > 0) {
			i *= 10;
			i += (num % 10);
			num /= 10;
		}

		return i;
	}

}
