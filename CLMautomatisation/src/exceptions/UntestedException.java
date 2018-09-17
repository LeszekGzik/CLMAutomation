package exceptions;

/** Wyj¹tek rzucany przy niewykonanym teœcie. */
public class UntestedException extends Exception {
	
	private static final long serialVersionUID = 1L;

	public UntestedException(String message) {
		super(message);
	}
}
