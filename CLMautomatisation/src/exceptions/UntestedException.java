package exceptions;

/** Wyj�tek rzucany przy niewykonanym te�cie. */
public class UntestedException extends Exception {
	
	private static final long serialVersionUID = 1L;

	public UntestedException(String message) {
		super(message);
	}
}
