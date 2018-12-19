package inputs.web;

import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Sprawdza czy element istnieje na stronie. Jeœli nie, rzuca TestFailedException. */
public class ElementExistsInput extends WebInput {

	public ElementExistsInput(Config config, WebTest parent) {
		super(config, parent);
	}
	
	public void fill(PList testdata) throws Exception {
		try {
			super.fill(testdata);
		}
		catch (TimeoutException te) {
			throw new TestFailedException("Element doesn't exist, but it should: " + xpath);
		}
	}

}
