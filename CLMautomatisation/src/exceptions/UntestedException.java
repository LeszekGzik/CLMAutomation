package exceptions;

/** Wyj�tek rzucany przy niewykonanym. Zawiera dodatkowo informacj� na temat momentu rzucenia wyj�tku (test, krok, polecenie) */
public class UntestedException extends Exception {
	
	private static final long serialVersionUID = 1L;

	public UntestedException(String message) {
		super(message);
	}
}
