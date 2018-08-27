package main;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.Properties;

import javax.xml.stream.XMLStreamException;

import excel.*;
import testobjects.*;
import xml.*;
/** G³ówna klasa programu. Czyta zawartoœæ properties.xml i wykonuje podany w args[0] scenariusz testowy. */
public class Main {
	
	public static void main(String[] args) throws XMLStreamException, IOException {
		System.out.println("Starting CLMAutomation...");
		Properties properties = new Properties();
		int ok = 0, untested = 0, failed = 0;
		try {
	    	FileInputStream fis = new FileInputStream(".\\properties.xml");
	    	System.setProperty("log4j.configurationFile", ".\\log4j2.xml");
			properties.loadFromXML(fis);
		} catch(IOException ioe) {
			System.out.println(ioe);
		}
		
		TestObject.globalInit();
		
		if (args.length==1) {
			XMLReadWriter xml = new XMLReadWriter(args[0]);
			TestScenario scenario = xml.read(properties);
			scenario.setInputWait();
			scenario.loadTests();
			scenario.executeAllTests();
			ok = scenario.getNumberOfOkTests();
			failed = scenario.getNumberOfFailedTests();
			untested = scenario.getNumberOfUntestedTests();
			Integer[][] contents = {{ok, failed, untested}};
			ExcelWriter.appendWithInt(properties.getProperty("xlsoutput"), contents);
		}
	}
}