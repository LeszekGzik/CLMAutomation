package main;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.util.Properties;

import excel.*;
import inputs.Input;
import testobjects.*;

/** G³ówna klasa programu. Czyta zawartoœæ properties.xml i wykonuje wszystkie scenariusze testowe zawarte w folderze Scenarios. */
public class Main {
	
	public static void main(String[] args) {
		Properties properties = new Properties();
		try {
	    	FileInputStream fis = new FileInputStream(".\\properties.xml");
	    	System.setProperty("log4j.configurationFile", ".\\log4j2.xml");
			properties.loadFromXML(fis);
		} catch(IOException ioe) {
			System.out.println(ioe);
		}
		
		String scenariofolder = properties.getProperty("scenarios");
		TestObject.globalInit();
		Input.setInputWait(Integer.parseInt(properties.getProperty("waitforinput"))/2);
		File[] folder = new File(scenariofolder).listFiles();
		int ok = 0, untested = 0, failed = 0;
		for (File file : folder) {
			try {
				TList setup = ExcelReader.readVertical(file.getAbsolutePath());
				TestScenario scenario = new TestScenario(file.getName(), setup, properties);
				scenario.executeAllTests();
				ok = scenario.getNumberOfOkTests();
				failed = scenario.getNumberOfFailedTests();
				untested = scenario.getNumberOfUntestedTests();
			} catch(Exception e) {
				System.out.println(e);
			}
			Integer[][] contents = {{ok, failed, untested}};
			ExcelWriter.appendWithInt(properties.getProperty("xlsoutput"), contents);
		}
	}
}