package inputs.web;

import excel.Config;
import excel.PList;
import inputs.Input;
import testobjects.TestObject;
import testobjects.WebTest;

/** Przechodzi pod wskazany URL. Wymaga tylko Name. */
public class GoToInput extends WebInput {
	
	@Override
	public void fill(PList testdata) throws InterruptedException {
		
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
		driver.navigate().to(data);
	}
	
	public GoToInput(Config config, WebTest parent) {
		super(config, parent);
	}
}
