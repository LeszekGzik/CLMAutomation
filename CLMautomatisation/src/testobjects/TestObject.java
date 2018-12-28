package testobjects;

import java.io.IOException;
import java.util.*;
import excel.Config;
import excel.PList;
import exceptions.*;
import inputs.*;
import logging.ReportManager;

public class TestObject {
	
	public List<Input> inputs;
	public PList testdata;
	public Set<String> steps;
	public static ReportManager report;
	public static PList globaldata;
	public String name;
	String parentName;
	public Boolean continueTest;
	int maxRepetitions;
	
	/** Wykonuje wszystkie polecenia w kroku STEP
	 * @return true je�li krok wykona� si� w ca�o�ci 
	 * @throws TestFailedException kiedy test si� nie powiedzie 
	 * @throws IOException kiedy okno zosta�o zamkni�te i nie mo�na zaraportowa� b��du */
	public boolean performStep(String step) throws TestFailedException, IOException {
		TestFailedException temp = null;
		for (Input input : inputs) {
			try {
				if (input.step.equals(step)) {
					if (continueTest) {
						//Je�li maxrepetitions > 1 ORAZ input si� nie wype�ni�, pr�buj ponownie
						for(int i=0; i<maxRepetitions; i++) {	
							try {
								input.fill(testdata);
								break;
							} catch(Exception exception) {
								System.out.println("ERROR #"+(i+1));
								if (i==(maxRepetitions-1)) {
									throw exception;
								}
							}
						}
						if (!input.continueStep) {
							return false;
						}
						report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "OK", ReportManager.currentDateTime());
					}
					else {
						report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "UNTESTED", ReportManager.currentDateTime());
					}
				}
			} catch(Exception exception) {
				report.debug(parentName, name, step, input.type + " (" + input.xpath + ", " + input.name + ")", "FAILED", ReportManager.currentDateTime());
				temp = new TestFailedException(exception, name, step, input.type);
				continueTest = false;
			}
		}
		if (temp!=null) { throw temp; }
		return true;
	}

	/** Wykonuje wszystkie kroki, w kolejno�ci w jakiej by�y podane */
	public void performAllSteps() throws TestFailedException, UntestedException, IOException {
		TestFailedException temp = null;
		for (String step : steps) {
			try {
				if (continueTest) {
					boolean stepComplete = performStep(step);
					if (stepComplete) {
						report.step(parentName, name, step, "OK", ReportManager.currentDateTime());
					}
					else {
						report.step(parentName, name, step, "SKIPPED", ReportManager.currentDateTime());
					}
				}
				else {
					report.step(parentName, name, step, "UNTESTED", ReportManager.currentDateTime());
				}
			} catch (TestFailedException tfe) {
				report.step(parentName, name, step, "FAILED", ReportManager.currentDateTime());
				temp = tfe;
			}
		}
		if (temp!=null) { throw temp; }
		else if (!continueTest) { throw new UntestedException("UntestedException: Test has been stopped due to IFT or similiar command."); }
	}
	
	public TestObject(String name, String parentName, List<Config> config, PList testdata, Properties properties) {
		this.name = name;
		this.parentName = parentName;
		continueTest = true;
		maxRepetitions = Integer.parseInt(properties.getProperty("maxrepetitions"));
		this.testdata = testdata;
		inputs = new ArrayList<Input>();
		steps = new LinkedHashSet<String>();
	}
	
	/** Tworzy list� krok�w do wykonania (unikatowych warto�ci Step w pliku config). */
	public void getSteps() {
		for (Input i : inputs) {
			steps.add(i.step);
		}
	}

	/** Inicjalizuje list� globalnych parametr�w (globaldata) */
	public static void globalInit() {
		globaldata = new PList();
	}
	
	/**	Zamyka sesj� w kt�rej odbywa si� test. Powinno by� wywo�ywane zawsze na zako�czenie testu w klasach potomnych. */
	public void close() {
		
	}
}
