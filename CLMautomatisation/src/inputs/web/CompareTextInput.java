package inputs.web;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Sprawdza czy element o podanym XPATH zawiera tekst identyczny z NAME. Jeœli nie, rzuca TestFailedException. */
public class CompareTextInput extends WebInput {

	public CompareTextInput(Config config, WebTest parent) {
		super(config, parent);
	}

	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		String data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata.get(name.substring(1));
		}
		else if (name.charAt(0)=='$') {
			data = name.substring(1);
		}
		else {
			data = testdata.get(name);
		}
		
		if(driver.findElement(By.xpath(xpath)).getText()!=data){
			throw new TestFailedException("Text at " + xpath + " does not equal " + data + ".");
		}
	}
}
