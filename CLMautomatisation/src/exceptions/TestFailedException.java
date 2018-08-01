package exceptions;

/** Wyj¹tek rzucany przy nieudanym teœcie. Zawiera dodatkowo informacjê na temat momentu rzucenia wyj¹tku (test, krok, polecenie) */
public class TestFailedException extends Exception {

	private static final long serialVersionUID = 1L;
	String test;
	String step;
	String command;
	
	public TestFailedException(String message) {
		super(message);
	}
	
	public TestFailedException(Exception ex, String test, String step, String command) {
		super(ex);
		this.test = test;
		this.step = step;
		this.command = command;
	}
	
	public String getTestInfo() {
		return test;
	}
	
	public String getStepInfo() {
		return step;
	}
	
	public String getCommandInfo() {
		return command;
	}
}
