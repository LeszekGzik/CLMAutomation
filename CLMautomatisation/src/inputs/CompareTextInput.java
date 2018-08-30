package inputs;

import org.openqa.selenium.By;
import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import testobjects.TestObject;

/** Sprawdza czy element o podanym XPATH zawiera tekst identyczny z NAME. Je�li nie, rzuca TestFailedException. */
public class CompareTextInput extends Input {

	public CompareTextInput(Config config, TestObject parent) {
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