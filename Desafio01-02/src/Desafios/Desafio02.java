package Desafios;

public class Desafio02 {

	public static void main(String[] args) {
		System.out.println(verificaAula());
	}
	
	public static String verificaAula() {
		int x = 3;
		int tempoChegada[] = { -2, -1, 0, 1, 2};
		int contNormal = 0;
		int contAtraso = 0;
		
		for (int i = 0; i < tempoChegada.length; i++) {
			if (tempoChegada[i] <= 0) {
				contNormal++;
			} else {
				contAtraso++;
			}
		}
		
		if (contNormal >= x) {
			return "aula normal";
		} else {
			return "aula cancelada";
		}
	}
	
}
