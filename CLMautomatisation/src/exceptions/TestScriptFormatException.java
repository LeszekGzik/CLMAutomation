package exceptions;

public class TestScriptFormatException extends Exception {
	String scenarioName, testName;

	public TestScriptFormatException(String testName, String scenarioName) {
		super();
		this.scenarioName = scenarioName;
		this.testName = testName;
	}

	public String getMessage() {
		return "Error reading test " + testName + " in scenario " + scenarioName + ": improper test script format - test type denominator missing.";
	}
}
