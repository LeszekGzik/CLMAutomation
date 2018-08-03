package testobjects;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Properties;

import excel.*;
import exceptions.*;
import inputs.Input;
import logging.ReportManager;
import xml.*;

/** Scenariusz, zawieraj¹cy kolekcjê testów i przynale¿nych do nich danych. */
public class TestScenario {
	public ArrayList<PTable> testdata;
	public List<List<Config>> configs;
	public TList tests;
	String name;
	public Properties properties;
	public ReportManager report;
	int okTests, untestedTests, failedTests;

	public TestScenario() {
		okTests = 0;
		untestedTests = 0;
		failedTests = 0;
		testdata = new ArrayList<PTable>();
		configs = new ArrayList<List<Config>>();
		tests = new TList();
	}
	
	public TestScenario(String name, TList tests, Properties properties) {
		this.tests = tests;
		this.properties = properties;
		//this.name = name.substring(0, name.lastIndexOf('.'));
		this.name = name;
		testdata = new ArrayList<PTable>();
		configs = new ArrayList<List<Config>>();
		okTests = 0;
		untestedTests = 0;
		failedTests = 0;
		
		loadTests();
	}
	
	public void addTest(SingleTest test) {
		tests.add(test);
	}
	
	public void loadTests() {
		for(int i = 0; i<tests.size(); i++) {
			configs.add(ExcelReader.readConfig(tests.getCase(i)));
			for (int j = 0; j<i; j++) {
				if (tests.getData(i).equals(tests.getData(j))) {	//szukanie powtarzaj¹cych siê zestawów danych
					testdata.add(testdata.get(j));
					break;
				}
			}
			if (testdata.size()<(i+1)) {							//jeœli zestaw danych siê nie powtarza, odczytaj i dodaj nowy
				testdata.add(ExcelReader.readHorizontal(tests.getData(i)));
			}
		}
	}
	
	/** Wykonuje test o indeksie INDEX po jednym razie dla ka¿dego dostêpnego zestawu danych. */
	public void executeTest(int index) throws IOException {
		TestObject testObject = null;
		for (int i=0; i<testdata.get(index).getSize(); i++) {
			try {
				testObject = new TestObject(tests.getNameOf(index), name, configs.get(index), testdata.get(index).get(i), properties);
				report = new ReportManager(testObject.driver, properties);
				testObject.performAllSteps();
				report.test(name, tests.getNameOf(index), "OK", ReportManager.currentDateTime());
				okTests++;
				testObject.close();
			} catch(TestFailedException tfe) {
				report.test(name, tests.getNameOf(index), "FAILED", ReportManager.currentDateTime());
				failedTests++;
				report.error(tfe.getTestInfo() + " - " + tfe.getStepInfo() + "(" + ReportManager.formattedDateTime() + ")", tfe.getMessage());
				testObject.close();
			} catch(UntestedException ue) {
				report.test(name, tests.getNameOf(index), "UNTESTED", ReportManager.currentDateTime());
				untestedTests++;
				testObject.close();
			}
		}
	}
	
	/** Wykonuje wszystkie testy w scenariuszu, dla wszystkich zestawów danych.
	 * Zestawy s¹ wspólne dla testów (i.e. parametry zmienione przez test 1 bêd¹ nadal zmienione w teœcie 2 dla tych samych danych) */
	public void executeAllTests() throws IOException {
		for(int i=0; i<tests.size(); i++) {
			executeTest(i);
		}
		if ((failedTests==0)&&(untestedTests==0)) {
			report.scenario(name, "OK", ReportManager.currentDateTime());
		}
		else {
			report.scenario(name, "FAILED", ReportManager.currentDateTime());
		}
	}
	
	public int getNumberOfOkTests() {
		return okTests;
	}
	
	public int getNumberOfFailedTests() {
		return failedTests;
	}
	
	public int getNumberOfUntestedTests() {
		return untestedTests;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	public void setProperty(String key, String value) {
		properties.setProperty(key, value);
	}
	
	public void setProperties(Properties props) {
		properties = new Properties();
		properties.setProperty("geckodriver", props.getProperty("geckodriver"));
		properties.setProperty("firefox", props.getProperty("firefox"));
		properties.setProperty("proxy", props.getProperty("proxy"));
	}

	public void addTests(TList tests) {
		this.tests = tests;
	}
	
	public Properties getProperties() {
		return properties;
	}
	
	public void setInputWait() {
		Input.setInputWait(Integer.parseInt(properties.getProperty("waitforinput")));
	}
}
