package inputs;

import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import testobjects.TestObject;

/** Sprawdza czy element istnieje na stronie. Jeœli tak, rzuca TestFailedException. */
public class ElementNotExistsInput extends Input {

	public ElementNotExistsInput(Config config, TestObject parent) {
		super(config, parent);
	}
	
	public void fill(PList testdata) throws Exception {
		boolean exists = true;
		try {
			super.fill(testdata);
		}
		catch (TimeoutException te) {
			exists = false;
		}
		finally {
			if (exists) {
				throw new TestFailedException("Element exists, but it shouldn't: " + xpath);
			}
		}
	}
}
