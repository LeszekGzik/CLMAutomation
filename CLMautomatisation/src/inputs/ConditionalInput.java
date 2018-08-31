package inputs;

import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import exceptions.TestFailedException;
import testobjects.TestObject;

/** Je�li podano NAME, ustawi flag� continueStep na false, je�li zadany parametr jest pusty w testdata.
 *  Je�li podano XPATH, ustawi flag� continueStep na false, je�li dany element nie istnieje na stronie.
 * Krok wtedy zostanie zatrzymany. */
public class ConditionalInput extends Input {
	@Override
	public void fill(PList testdata) throws Exception {
		if (!name.equals("")) {
			PList data;
			if (name.charAt(0)=='&') {
				data = TestObject.globaldata;
				name = name.substring(1);
			}
			else {
				data = testdata;
			}
			
			if (data.get(name)==null) {
				continueStep = false;
			}
			else if (data.get(name).equals("")) {
				continueStep = false;
			}
		}
		if (!xpath.equals("")) {
			try {
				super.fill(testdata);
			}
			catch (TimeoutException te) {
				continueStep = false;
			}
		}
	}
	
	public ConditionalInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
