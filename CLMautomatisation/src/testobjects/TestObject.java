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
	 * @return true jeœli krok wykona³ siê w ca³oœci 
	 * @throws TestFailedException kiedy test siê nie powiedzie 
	 * @throws IOException kiedy okno zosta³o zamkniête i nie mo¿na zaraportowaæ b³êdu */
	public boolean performStep(String step) throws TestFailedException, IOException {
		TestFailedException temp = null;
		for (Input input : inputs) {
			try {
				if (input.step.equals(step)) {
					if (continueTest) {
						//Jeœli maxrepetitions > 1 ORAZ input siê nie wype³ni³, próbuj ponownie
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

	/** Wykonuje wszystkie kroki, w kolejnoœci w jakiej by³y podane */
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
	
	/** Tworzy listê kroków do wykonania (unikatowych wartoœci Step w pliku config). */
	public void getSteps() {
		for (Input i : inputs) {
			steps.add(i.step);
		}
	}

	/** Inicjalizuje listê globalnych parametrów (globaldata) */
	public static void globalInit() {
		globaldata = new PList();
	}
	
	/**	Zamyka sesjê w której odbywa siê test. Powinno byæ wywo³ywane zawsze na zakoñczenie testu w klasach potomnych. */
	public void close() {
		
	}
}
