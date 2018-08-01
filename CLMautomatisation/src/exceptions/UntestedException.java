package exceptions;

/** Wyj¹tek rzucany przy niewykonanym. Zawiera dodatkowo informacjê na temat momentu rzucenia wyj¹tku (test, krok, polecenie) */
public class UntestedException extends Exception {
	
	private static final long serialVersionUID = 1L;

	public UntestedException(String message) {
		super(message);
	}
}
