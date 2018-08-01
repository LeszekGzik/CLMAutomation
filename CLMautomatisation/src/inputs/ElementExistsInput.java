package inputs;

import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import testobjects.TestObject;

/** Sprawdza czy element istnieje na stronie. Jeœli nie, rzuca TestFailedException. */
public class ElementExistsInput extends Input {

	public ElementExistsInput(Config config, TestObject parent) {
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
