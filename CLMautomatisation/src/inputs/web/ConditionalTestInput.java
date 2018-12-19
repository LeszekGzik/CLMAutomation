package inputs.web;

import org.openqa.selenium.TimeoutException;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Identyczne do ConditionalInput, ale zatrzymuje ca³y test, nie tylko krok */
public class ConditionalTestInput extends WebInput {
	
	@Override
	public void fill(PList testdata) throws Exception {
		PList data;
		if (!name.equals("")) {
			if (name.charAt(0)=='&') {
				data = TestObject.globaldata;
				name = name.substring(1);
			}
			else {
				data = testdata;
			}
			
			if (data.get(name)==null) {
				continueStep = false;
				parent.continueTest = false;
			}
			else if (data.get(name).equals("")) {
				continueStep = false;
				parent.continueTest = false;
			}
		}
		if (!xpath.equals("")) {
			try {
				super.fill(testdata);
			}
			catch (TimeoutException te) {
				continueStep = false;
				parent.continueTest = false;
			}
		}
	}
	
	public ConditionalTestInput(Config config, WebTest parent) {
		super(config, parent);
	}

}
